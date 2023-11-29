# Only used for direct (vs. marketplace) subscriptions
data "rediscloud_payment_method" "card" {
  card_type = "Visa"
}

resource "rediscloud_subscription" "subscription-resource" {

  name = var.subscription-name
  memory_storage = "ram"

  # change these lines to variables (if through marketplace you don't need them)
  payment_method = var.use_marketplace ? "marketplace" : "credit-card"
  payment_method_id = var.use_marketplace ? null : data.rediscloud_payment_method.card.id

  cloud_provider {
    provider = data.rediscloud_cloud_account.account.provider_type
    cloud_account_id = data.rediscloud_cloud_account.account.id
    region {
      region = "eu-west-1"
      multiple_availability_zones = false
      networking_deployment_cidr = "10.0.1.0/24"
      preferred_availability_zones = []
    }
  }

  // This block needs to be defined for provisioning a new subscription.
  // This allows creation of a well-optimized hardware specification for databases in the cluster
  creation_plan {
    memory_limit_in_gb = var.memorylimit
    quantity = 1
    replication= var.replication
    throughput_measurement_by = var.throughput_measurement_by
    throughput_measurement_value = var.throughput_measurement_value
    modules = var.modules
  }
}