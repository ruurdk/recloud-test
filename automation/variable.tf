// RedisCloud direct vs. Marketplace account?
variable "use_marketplace" {
    default = false
}

// names
variable "subscription-name" {
    default = "ruurd-sub-poc"
}

variable "database-name" {
    default = "ruurd-db-poc"
}

// sane defaults for JSON + Search (duplicated between creation plan + database as we have only 1 DB in this sub.)
variable "memorylimit" {
    default = "75"
}

variable "throughput_measurement_by" {
  default = "number-of-shards"
}

variable "throughput_measurement_value" {
  default = "3"
}

variable "replication" {
  default = true
}

variable "modules" {
    type = list(string)
    default = ["RedisJSON", "RediSearch"]
}
