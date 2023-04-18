using System.Text;
using HotelReservationCSharp.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Person> guests = new List<Person>();

Person g1 = new Person(name: "Guest 1");
Person g2 = new Person(name: "Guest 2");
Person g3 = new Person(name: "Guest 3");
Person g4 = new Person(name: "Guest 4");

guests.Add(g1);
guests.Add(g2);
guests.Add(g3);
guests.Add(g4);

Room room = new Room(roomType: "Premium", capacity: 3, valueDay: 30);

Reservation reservation = new Reservation(reservationDays: 10);
reservation.RegisterRoom(room);
reservation.GuestsRegister(guests);

Console.WriteLine($"Guests: {reservation.GetGuestsQuantity()}");
Console.WriteLine($"Value per day: {reservation.CalcValueDay}");

