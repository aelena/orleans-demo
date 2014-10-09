orleans-demo
============

 demo to learn about Microsoft Research Orleans Project

the following is from http://research.microsoft.com/en-us/projects/orleans/default.aspx

A Framework for Cloud Computing Orleans is a project to simplify development of scalable cloud services.

Building interactive services that are scalable and reliable is hard. Interactivity imposes strict constraints on availability and latency, as that directly impacts end-user experience. To support a large number of concurrent user sessions, high throughput is essential.

The traditional three-tier architecture with stateless front-ends, stateless middle tier and a storage layer has limited scalability due to latency and throughput limits of the storage layer, which has to be consulted for every request. A caching layer is often added between the middle tier and storage to improve performance. However, a cache loses most of the concurrency and semantic guarantees of the underlying storage layer. To prevent inconsistencies caused by concurrent updates to a cached item, the application or cache manager has to implement a concurrency control protocol. With or without a cache, a stateless middle tier does not provide data locality because it uses the data shipping paradigm: for every request, data is sent from storage or cache to the middle tier server that is processing the request. The advent of social graphs where a single request may touch many entities connected dynamically with multi-hop relationships makes it even more challenging to satisfy required application-level semantics and consistency on a cache with fast response for interactive access.

The actor model offers an appealing solution to these challenges by relying on the function shipping paradigm. Actors allow building a stateful middle tier that has the performance benefits of a cache with the data locality and semantic and consistency benefits of encapsulated entities via application-specific operations. In addition, actors make it easy to implement horizontal, “social”, relations between entities in the middle tier.

Another view of distributed systems programmability is through the lens of the object-oriented programming (OOP) paradigm. While OOP is an intuitive way to model complex systems, it has been marginalized by the popular service-oriented architecture (SOA). One can still benefit from OOP when implementing service components. However, at the system level, developers have to think in terms of loosely-coupled partitioned services, which often do not match the application’s conceptual objects. This has contributed to the difficulty of building distributed systems by mainstream developers. The actor model brings OOP back to the system level with actors appearing to developers very much like the familiar model of interacting objects.

Actor platforms such as Erlang and Akka are a step forward in simplifying distributed system programming. However, they still burden developers with many distributed system complexities because of the relatively low level of provided abstractions and system services. The key challenges are developing application code for managing the lifecycle of actors, dealing with distributed races, handling failures and recovery of actors, placing actors, and thus managing distributed resources. To build a correct solution to such problems in the application, the developer must be a distributed systems expert.

To avoid these complexities, we built the Orleans programming model and runtime, which raises the level of the actor abstraction. Orleans targets developers who are not distributed system experts, although our expert customers have found it attractive too. It is actor-based, but differs from existing actor-based platforms by treating actors as virtual entities, not as physical ones. First, an Orleans actor always exists, virtually. It cannot be explicitly created or destroyed. Its existence transcends the lifetime of any of its in-memory instantiations, and thus transcends the lifetime of any particular server. Second, Orleans actors are automatically instantiated: if there is no in-memory instance of an actor, a message sent to the actor causes a new instance to be created on an available server. An unused actor instance is automatically reclaimed as part of runtime resource management. An actor never fails: if a server S crashes, the next message sent to an actor A that was running on S causes Orleans to automatically re-instantiate A on another server, eliminating the need for applications to supervise and explicitly re-create failed actors. Third, the location of the actor instance is transparent to the application code, which greatly simplifies programming. And fourth, Orleans can automatically create multiple instances of the same stateless actor, seamlessly scaling out hot actors.

Overall, Orleans gives developers a virtual “actor space” that, analogous to virtual memory, allows them to invoke any actor in the system, whether or not it is present in memory. Virtualization relies on indirection that maps from virtual actors to their physical instantiations that are currently running. This level of indirection provides the runtime with the opportunity to solve many hard distributed systems problems that must otherwise be addressed by the developer, such as actor placement and load balancing, deactivation of unused actors, and actor recovery after server failures, which are notoriously difficult for them to get right. Thus, the virtual actor approach significantly simplifies the programming model while allowing the runtime to balance load and recover from failures transparently.

The runtime supports indirection via a distributed directory that mas from actor identity to its current physical location. Orleans minimizes the runtime cost of indirection by using local caches of that map. This strategy has proven to be very efficient. We typically see cache hit rates of well over 90% in our production services.

Orleans has been used to build multiple production services currently running on the Microsoft Windows Azure cloud, including the back-end services for some popular games. This enabled us to validate the scalability and reliability of production applications written using Orleans, and adjust its model and implementation based on this feedback. It also enabled us to verify, at least anecdotally, that the Orleans programming model leads to significantly increased programmer productivity.
