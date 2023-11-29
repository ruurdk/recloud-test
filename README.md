# recloud-test

A repository for spinning up a Redis Enterprise Cloud database and client for testing address search on 40M records.

To do this, we provide automation (terraform) to deploy the infrastructure, scripts to fill the database and create indices, and an application to test queries.

## Getting started

### Prerequisites

- Existing RE Cloud API access (through api key + secret key), exported as environment variables (see main.tf)
- Terraform installed
- Configure marketplace or RE Cloud direct access in variable.tf (default = direct)

### Deploying

Go into the automation folder and 'terraform apply'. Note that this may on the first run take 10-15 minutes as dedicated infrastructure is provisioned. Changes to databases & configuration will be much quicker afterwards.

### Set-up data & Indices

For local testing/demo, read [this](data/README.md).

For remote (at scale) setup, do the same as above, but with Faker and RedisInsight against the public endpoint.

### Performance testing from inside AWS

Setup a EC2 instance. Make sure to setup networking inside a VPC (non-overlapping range with RE Cloud subscription), and allow SSH traffic (you will need an internet gateway added to VPC with 0.0.0.0/32 rule applied).

Add VPC peering from inside the RE Cloud console to the VPC with the VM.
Add routing to the subnet of RE to the VPC with the VM.

Inside the VM, clone this repo, install dotnet sdk and insert data + apply index. Then clone the memtier_benchmark repo and build it.

Run this command:
`memtier_benchmark -s <private RE ip> -p <RE port> --show-config --test-time=60 -t 2 -c 8 --pipeline=1 --command="FT.SEARCH idx:address_json "Henry""`

