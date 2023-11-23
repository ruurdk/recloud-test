# Demo flow

- Show the [iso 20022 address format](iso20022-address-format.md)
- Spin up a local Redis instance with RedisInsight: `docker run -d --name redis-stack -p 6379:6379 -p 8001:8001 redis/redis-stack:latest`
- Show the GUI and data in database.
- Load a small set of data (~1000s of addresses) with [faker](faker/README.md)
- [Apply the index](query/index.md) through workbench and explain it.
- [Query the index](query/index.md).
- Load much more data (few M records will do).
- Query again.
