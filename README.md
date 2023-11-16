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

### Run scripts

Go into the scripts folder and run the scripts against the public endpoint.