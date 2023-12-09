// namespace BevyECS.Event;
//
// public class EventTests
// {
//     record struct TestEvent(int i) : IEvent;
//
//     [Fact]
//     void TestReader() {
//         EventReader<TestEvent> eventReader;
//         foreach (TestEvent e in eventReader) {
//             
//         }
//     }
//
//     [Fact]
//     void test_events() {
//         var events = new Events<TestEvent>();
//         var event_0 = new TestEvent(0);
//         var event_1 = new TestEvent(1);
//         var event_2 = new TestEvent(2);
//
//         // this reader will miss event_0 and event_1 because it wont read them over the course of
//         // two updates
//         var reader_missed = events.get_reader();
//
//         var reader_a = events.get_reader();
//
//         events.Send(event_0);
//
//
//         // "reader_a created before event receives event"
//         Assert.Equal(
//             get_events(events, reader_a),
//             new[] { event_0 }
//         );
//
//         // "second iteration of reader_a created before event results in zero events"
//         Assert.Equal(
//             get_events(events, reader_a),
//             Array.Empty<TestEvent>()
//         );
//
//         var reader_b = events.get_reader();
//
//         // "reader_b created after event receives event"
//         Assert.Equal(
//             get_events(events, reader_b),
//             new[] { event_0 }
//         );
//         //"second iteration of reader_b created after event results in zero events"
//         Assert.Equal(get_events(events, reader_b), Array.Empty<TestEvent>());
//
//         events.Send(event_1);
//
//         var reader_c = events.get_reader();
//
//         // "reader_c created after two events receives both events"
//         Assert.Equal(
//             get_events(events, reader_c),
//             new[] { event_0, event_1 }
//         );
//
//         // "second iteration of reader_c created after two event results in zero events"
//         Assert.Equal(
//             get_events(events, reader_c),
//             Array.Empty<TestEvent>()
//         );
//
//         // "reader_a receives next unread event"
//         Assert.Equal(
//             get_events(events, reader_a),
//             new[] { event_1 }
//         );
//
//         events.Update();
//
//         var reader_d = events.get_reader();
//
//         events.Send(event_2);
//
//         // "reader_a receives event created after update"
//         Assert.Equal(
//             get_events(events, reader_a),
//             new[] { event_2 }
//         );
//         // "reader_b receives events created before and after update"
//         Assert.Equal(
//             get_events(events, reader_b),
//             new[] { event_1, event_2 }
//         );
//         // "reader_d receives all events created before and after update"
//         Assert.Equal(
//             get_events(events, reader_d),
//             new[] { event_0, event_1, event_2 }
//         );
//
//         events.Update();
//         // "reader_missed missed events unread after two update() calls"
//         Assert.Equal(
//             get_events(events, reader_missed),
//             new[] { event_2 }
//         );
//     }
//
//     E[] get_events<E>(
//         Events<E> events,
//         ManualEventReader<E> reader
//     ) where E : IEvent {
//         reader.iter(events).cloned().collect::<Vec < E >> ()
//     }
//
//     record struct E(uint i) : IEvent;
//
//     void events_clear_and_read_impl(clear_func: impl FnOnce( Events<E>)) {
//         var events = new Events<E>();
//         var reader = events.get_reader();
//
//         Assert.Null(reader.iter(events).next());
//
//         events.Send(new E(0));
//         Assert.Equal(*reader.iter(events).next().unwrap(), E(0));
//         Assert.Null(reader.iter(events).next());
//
//         events.Send(new E(1));
//         clear_func(events);
//         Assert.Null(reader.iter(events).next());
//
//         events.Send(new E(2));
//         events.Update();
//         events.Send(new E(3));
//
//         Assert.True(reader.iter(events).eq([E(2), E(3)].iter()));
//     }
//
//     [Fact]
//     void test_events_clear_and_read() {
//         events_clear_and_read_impl( | events | events.clear());
//     }
//
//     [Fact]
//     void test_events_drain_and_read() {
//         events_clear_and_read_impl( | events | {
//             Assert.True(events.drain().eq(new[] {
//                 E(0), E(1)].into_iter()));
//             });
//         }
//
//         [Fact]
//         void test_events_extend_impl() {
//             var events = new Events<TestEvent>();
//             var reader = events.get_reader();
//
//             events.Extend(new[] { new TestEvent(0),                new TestEvent(1) });
//         Assert.Equal(reader.iter(events), new[] { new TestEvent(0), new TestEvent(1) });
//     }
//
//     [Fact]
//     void test_events_empty() {
//         var events = new Events<TestEvent>();
//         Assert.True(events.is_empty());
//
//         events.Send(new TestEvent(
//             0
//     });
//
//     Assert.True(!events.is_empty());
//
//     events.update();
//     Assert.True(!events.is_empty());
//
//     // events are only empty after the second call to update
//     // due to double buffering.
//     events.update();
//     Assert.True(events.is_empty());
// }
//
// [Fact]
// void test_event_reader_len_empty() {
//     var events = new Events<TestEvent>();
//     Assert.Equal(events.get_reader().len(events), 0);
//     Assert.True(events.get_reader().is_empty(events));
// }
//
// [Fact]
// void test_event_reader_len_filled() {
//     var events = new Events<TestEvent>();
//     events.Send(new new TestEvent(
//         0
// })
//
// ;
// Assert.Equal(events.get_reader().len(events), 1);
// Assert.True(!events.get_reader().is_empty(events));
//
// }
//
// [Fact]
// void test_event_iter_len_updated() {
//     var events = new Events<TestEvent>();
//     events.Send(new TestEvent(
//         0
//     ));
//     events.Send(new TestEvent(
//         1
// })
//
// ;
// events.Send(new TestEvent(
//     2
// });
// var reader = events.get_reader();
// var iter = reader.iter(events);
// Assert.Equal(iter.len(), 3);
// iter.next();
// Assert.Equal(iter.len(), 2);
// iter.next();
// Assert.Equal(iter.len(), 1);
// iter.next();
// Assert.Equal(iter.len(), 0);
// }
//
// [Fact]
// void test_event_reader_len_current() {
//     var events = new Events<TestEvent>();
//     events.Send(new TestEvent(
//         0
// })
//
// ;
// var reader = events.get_reader_current();
// dbg!(reader);
// dbg!(events);
// Assert.True(reader.is_empty(events));
// events.Send(new TestEvent(
//     0
// });
// Assert.Equal(reader.len(events), 1);
// Assert.True(!reader.is_empty(events));
// }
//
// [Fact]
// void test_event_reader_len_update() {
//     var events = new Events<TestEvent>();
//     events.Send(new TestEvent(
//         0
// })
//
// ;
// events.Send(new TestEvent(
//     0
// });
// var reader = events.get_reader();
// Assert.Equal(reader.len(events), 2);
// events.update();
// events.Send(new TestEvent(
//     0
// });
// Assert.Equal(reader.len(events), 3);
// events.update();
// Assert.Equal(reader.len(events), 1);
// events.update();
// Assert.True(reader.is_empty(events));
// }
//
// [Fact]
// void test_event_reader_clear() {
//     use bevy_ecs::prelude::*;
//
//     var world = World::new();
//     var events = new Events<TestEvent>();
//     events.Send(new TestEvent(
//         0
// })
//
// ;
// world.insert_resource(events);
//
// var reader = IntoSystem::into_system( | events:
// EventReader<TestEvent> | -> bool {
//     if !events.is_empty() {
//         events.clear();
//         false
//     } else {
//         true
//     }
// });
// reader.initialize(world);
//
// var is_empty = reader.run((), world);
// Assert.True(!is_empty, "EventReader should not be empty");
// var is_empty = reader.run((), world);
// Assert.True(is_empty, "EventReader should be empty");
// }
//
// #[allow(clippy::iter_nth_zero)]
// [Fact]
// void test_event_iter_nth() {
//     use bevy_ecs::prelude::*;
//
//     var world = World::new();
//     world.init_resource::<Events < TestEvent >> ();
//
//     world.send_event(new TestEvent(
//         0
// })
//
// ;
// world.send_event(new TestEvent(
//     1
// });
// world.send_event(new TestEvent(
//     2
// });
// world.send_event(new TestEvent(
//     3
// });
// world.send_event(new TestEvent(
//     4
// });
// var schedule = Schedule::new();
// schedule.add_systems( | events:
// EventReader<TestEvent> | {
//     var iter = events.iter();
//
//     Assert.Equal(iter.next(), Some(TestEvent {
//         i:
//         0
//     }));
//     Assert.Equal(iter.nth(2), Some(TestEvent {
//         i:
//         3
//     }));
//     Assert.Equal(iter.nth(1), None);
//
//     Assert.True(events.is_empty());
// });
// schedule.run(world);
// }
//
// [Fact]
// void test_event_iter_last() {
//     use bevy_ecs::prelude::*;
//
//     var world = World::new();
//     world.init_resource::<Events < TestEvent >> ();
//
//     var reader =
//         IntoSystem::into_system( | events:
//     EventReader<TestEvent> | -> Option < TestEvent > {
//         events.iter().last().copied()
//     });
//     reader.initialize(world);
//
//     var last = reader.run((), world);
//     Assert.True(last.is_none(), "EventReader should be empty");
//
//     world.send_event(new TestEvent(
//         0
// })
//
// ;
// var last = reader.run((), world);
// Assert.Equal(last, Some(new TestEvent(
//     0
// }));
// world.send_event(new TestEvent(
//     1
// });
// world.send_event(new TestEvent(
//     2
// });
// world.send_event(new TestEvent(
//     3
// });
// var last = reader.run((), world);
// Assert.Equal(last, Some(new TestEvent(
//     3
// }));
// var last = reader.run((), world);
// Assert.True(last.is_none(), "EventReader should be empty");
// }
//
// #[derive(Event, Clone, PartialEq, Debug, Default)]
// struct EmptyTestEvent;
//
// [Fact]
// void test_firing_empty_event() {
//     var events = Events::<EmptyTestEvent >::default();
//     events.send_default();
//
//     var reader = events.get_reader();
//     Assert.Equal(
//         get_events(events, reader),
//         new[] {
//                 EmptyTestEvent::default()]
//                 );
//             }
//             [Fact]
//
//     void ensure_reader_readonly() {
//         void read_for<E:
//         Event > () {
//             var world = World::new();
//             world.init_resource::<Events < E >> ();
//             var state = SystemState::<EventReader < E >> ::new(world);
//             // This can only work if EventReader only reads the world
//             var _reader = state.get(world);
//         }
//         read_for::<EmptyTestEvent > ();
//     }
// }