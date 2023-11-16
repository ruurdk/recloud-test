terraform {
  required_providers {
    rediscloud = {
      source = "RedisLabs/rediscloud"
      version = "1.3.3"
    }
  }
}

provider "rediscloud" {
  # Configuration options
  # api_key = exposed in environment REDISCLOUD_ACCESS_KEY
  # secret_key = exposed in environment REDISCLOUD_SECRET_KEY
}

data "rediscloud_cloud_account" "account" {
  exclude_internal_account = true
}

# some outputs as sanity check
output "cloud_account_name" {
  value = data.rediscloud_cloud_account.account.name
}

output "cloud_account_id" {
  value = data.rediscloud_cloud_account.account.id
}

output "cloud_account_access_key_id" {
  value = data.rediscloud_cloud_account.account.access_key_id
}
