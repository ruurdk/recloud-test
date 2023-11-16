# recloud-test

This repo contains:

## Automation

- for setting up a Redis Enterprise Cloud subscription through Terraform
- creation of a database
- configuring appropriate security settings

## Scripts 

- for loading the database with 40M random address records
- for setting up indexing (to do search)

## App + deployment

- for querying the addresses
- for deploying infrastructure (VM) to AWS to host the app and connect through VPC


### Prerequisites

- Existing RE Cloud API access (through api key + secret key), exported as environment variables (see main.tf)
- Terraform installed
- Configure marketplace or RE Cloud direct access in variable.tf (default = direct)