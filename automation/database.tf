// The primary database to provision
resource "rediscloud_subscription_database" "database-resource" {
    subscription_id = rediscloud_subscription.subscription-resource.id
    name = var.database-name
    memory_limit_in_gb = var.memorylimit
    data_persistence = "aof-every-1-second"
    data_eviction = "noeviction"
    throughput_measurement_by = var.throughput_measurement_by
    throughput_measurement_value = var.throughput_measurement_value
    replication = var.replication
    modules =  [for mod_name in var.modules : {
        "name": mod_name
    } ]

    alert {
      name = "dataset-size"
      value = 80
    }
    depends_on = [rediscloud_subscription.subscription-resource]
}

output "public_database_endpoint" {
    value = resource.rediscloud_subscription_database.database-resource.public_endpoint
}
output "private_database_endpoint" {
    value = resource.rediscloud_subscription_database.database-resource.private_endpoint
}
output "default_user_password" {
    value = "Please see your tfstate file for this value"
}