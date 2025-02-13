﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace RestaurantSystem.CRUDO
{
    public static class ReservationRepository
    {
        public static List<Reservation> LoadItems(string filePath)
        {
            File.SetAttributes(filePath, FileAttributes.Normal); // Make file writeable if it is read-only.

            // Read the JSON file
            var json = File.ReadAllText(filePath);

            // Deserialize the JSON data
            var data = JsonSerializer.Deserialize<JsonReservationData>(json);

            // Create Reservation objects
            var reservations = new List<Reservation>();
            foreach (var reservationData in data.Reservations)
            {
                var reservation = new Reservation(
                    reservationData.StartTime,
                    reservationData.DurationMinutes,
                    reservationData.TableNumber,
                    reservationData.CustomerName,
                    reservationData.NumberOfGuests
                );
                reservations.Add(reservation);
            }

            return reservations;
        }

        public static void SaveItems(string filePath, List<Reservation> reservations)
        {

            File.SetAttributes(filePath, FileAttributes.Normal); // Make file writeable if it is read-only.

            // List of JSON reservations
            var jsonReservations = new List<JsonReservation>();

            // Convert reservations to JSON reservations
            foreach (var reservation in reservations)
            {
                jsonReservations.Add(new JsonReservation
                {
                    StartTime = reservation.StartTime,
                    DurationMinutes = reservation.DurationMinutes,
                    TableNumber = reservation.TableNumber,
                    CustomerName = reservation.CustomerName,
                    NumberOfGuests = reservation.NumberOfGuests
                });
            }

            // Wrap JSON reservations list in JsonReservationData object
            var data = new JsonReservationData
            {
                Reservations = jsonReservations
            };

            // Serialize the reservations as JSON data
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            // Write to the file
            File.WriteAllText(filePath, json);
        }

        public static void AddReservation(DateTime dateTime, int durationMinutes, int tableNumber, string customerName, int numberOfGuests)
        {
            // Load reservations
            var reservations = LoadItems("ReservationData.json");
            // Add the new reservation
            reservations.Add(new Reservation
                (
                dateTime,
                durationMinutes,
                tableNumber,
                customerName,
                numberOfGuests
                ));
            // Save reservations 
            SaveItems("ReservationData.json", reservations);
        }

        public static void RemoveReservation(Reservation reservation)
        {
            // Load reservations
            var reservations = LoadItems("ReservationData.json");

            // Remove all reservations which have the same time and customer.
            reservations.RemoveAll((Reservation r) => { return (r.StartTime == reservation.StartTime) && (r.CustomerName == reservation.CustomerName); });

            reservations.Remove(reservation);

            // Save reservations 
            SaveItems("ReservationData.json", reservations);
        }
    }
}
