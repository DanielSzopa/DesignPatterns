using Observer;

var subscriber1 = new Subscriber("subscribe1");
var subscriber2 = new Subscriber("subscribe2");
var subscriber3 = new Subscriber("subscribe3");

var publisher = new Publisher();

publisher.Subscribe(subscriber1);
publisher.Subscribe(subscriber2);
publisher.Subscribe(subscriber3);

publisher.Notify("Play-station 5 is available!");