using System.Text;
using HotelReservationCSharp.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Guest> guests = new List<Guest>();

Guest g1 = new Guest(name: "");
Guest g2 = new Guest(name: "");
Guest g3 = new Guest(name: "");
Guest g4 = new Guest(name: "");

guests.Add(g1);
guests.Add(g2);
guests.Add(g3);
guests.Add(g4);

Room room = new Room(typeRoom: "Premium", capacity: 3, valueDay: 30);

Reservation reservation = new Reservation(reservationDays: 10);
reservation.RegisterRoom(room);
reservation.RegisterGuest(guest);

Console.WriteLine($"Guests: {reservation.GetGuestsQuantity()}");
Console.WriteLine($"Value per day: {reservation.CalcValueDay}");

