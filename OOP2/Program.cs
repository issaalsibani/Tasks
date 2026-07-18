namespace OOP2
{
    public class Room
    {
        public int roomNumber { get; set; }
        public string roomType { get; set; }
        public double pricePerNight { get; set; }
        public bool isAvailable { get; set; }

        public void displayRoom()
        {
            Console.WriteLine("Room Number: " + roomNumber);
            Console.WriteLine("Room Type: " + roomType);
            Console.WriteLine("Price Per Night: " + pricePerNight);
            Console.WriteLine("Available: " + isAvailable);
        }
    }

    public class Guest
    {
        public string guestId { get; set; }
        public string guestName { get; set; }
        public string roomNumber { get; set; }
        public string checkInDate { get; set; }
        public int totalNights { get; set; }

        public double pricePerNight { get; set; }

        public void displayGuest()
        {
            Console.WriteLine("Guest ID: " + guestId);
            Console.WriteLine("Guest Name: " + guestName);
            Console.WriteLine("Room Number: " + roomNumber);
            Console.WriteLine("Check-in Date: " + checkInDate);
            Console.WriteLine("Total Nights: " + totalNights);
        }

        public double calculateTotalCost()
        {
            return totalNights * pricePerNight;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            Room room1 = new Room();
            room1.roomNumber = 101;
            room1.roomType = "Single";
            room1.pricePerNight = 25.000;
            room1.isAvailable = true;
            rooms.Add(room1);

            Room room2 = new Room();
            room2.roomNumber = 102;
            room2.roomType = "Single";
            room2.pricePerNight = 28.000;
            room2.isAvailable = true;
            rooms.Add(room2);

            Room room3 = new Room();
            room3.roomNumber = 201;
            room3.roomType = "Double";
            room3.pricePerNight = 40.000;
            room3.isAvailable = true;
            rooms.Add(room3);

            Room room4 = new Room();
            room4.roomNumber = 202;
            room4.roomType = "Double";
            room4.pricePerNight = 45.000;
            room4.isAvailable = true;
            rooms.Add(room4);

            Room room5 = new Room();
            room5.roomNumber = 301;
            room5.roomType = "Suite";
            room5.pricePerNight = 80.000;
            room5.isAvailable = true;
            rooms.Add(room5);

            Room room6 = new Room();
            room6.roomNumber = 302;
            room6.roomType = "Suite";
            room6.pricePerNight = 90.000;
            room6.isAvailable = true;
            rooms.Add(room6);
            

            Console.WriteLine("Rooms loaded successfully.");
            Console.WriteLine("Total rooms: " + rooms.Count);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("================================");
                Console.WriteLine("GRAND VISTA HOTEL");
                Console.WriteLine("================================");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddNewRoom(rooms);
                            break;

                        case 2:
                            RegisterNewGuest(guests);
                            break;

                        case 3:
                            BookRoomForGuest(rooms, guests);
                            break;

                        case 4:
                            ViewAllRooms(rooms);
                            break;

                        case 5:
                            ViewAllGuests(guests);
                            break;

                        case 6:
                            SearchAndFilterRooms(rooms);
                            break;

                        case 7:
                            GuestAndBookingStatistics(rooms, guests);
                            break;

                        case 8:
                            UpdateRoomPrice(rooms);
                            break;

                        case 9:
                            GuestLookupByName(guests);
                            break;

                        case 10:
                            RoomTypeBreakdownReport(rooms);
                            break;

                        case 11:
                            CheckOutGuest(rooms, guests);
                            break;

                        case 12:
                            RemoveUnavailableRooms(rooms, guests);
                            break;

                        case 13:
                            ExtendGuestStay(guests);
                            break;

                        case 14:
                            HighestRevenueBooking(guests);
                            break;

                        case 15:
                            GuestPaginationViewer(guests);
                            break;

                        case 0:
                            exit = true;
                            Console.WriteLine("Exiting system...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please choose from 0 to 15.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number only.");
                }

                Console.WriteLine();
            }
        }

        //Case 01 Add New Room
        static void AddNewRoom(List<Room> rooms)
        {
            Console.Write("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            if (roomNumber <= 0)
            {
                Console.WriteLine("Room number must be positive.");
                return;
            }

            bool roomExists = rooms.Any(room => room.roomNumber == roomNumber);

            if (roomExists)
            {
                Console.WriteLine("Room number already exists.");
                return;
            }

            Console.Write("Enter room type (Single / Double / Suite): ");
            string roomType = Console.ReadLine();

            Console.Write("Enter price per night: ");
            double pricePerNight = double.Parse(Console.ReadLine());

            if (pricePerNight <= 0)
            {
                Console.WriteLine("Price must be positive.");
                return;
            }

            Room newRoom = new Room();
            newRoom.roomNumber = roomNumber;
            newRoom.roomType = roomType;
            newRoom.pricePerNight = pricePerNight;
            newRoom.isAvailable = true;

            rooms.Add(newRoom);

            Console.WriteLine("Room added successfully.");
            Console.WriteLine("Room Number: " + newRoom.roomNumber);
            Console.WriteLine("Room Type: " + newRoom.roomType);
            Console.WriteLine("Price Per Night: " + newRoom.pricePerNight.ToString("F2"));
            Console.WriteLine("Total Rooms: " + rooms.Count());
        }

        //Case 02 Register New Guest 
        static void RegisterNewGuest(List<Guest> guests)
        {
            Console.Write("Enter guest name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter check-in date: ");
            string checkInDate = Console.ReadLine();

            Console.Write("Enter total nights: ");
            int totalNights = int.Parse(Console.ReadLine());

            if (totalNights <= 0)
            {
                Console.WriteLine("Total nights must be positive.");
                return;
            }

            string guestId = "G" + (guests.Count() + 1).ToString("D3");

            Guest newGuest = new Guest();
            newGuest.guestId = guestId;
            newGuest.guestName = guestName;
            newGuest.checkInDate = checkInDate;
            newGuest.totalNights = totalNights;
            newGuest.roomNumber = "Not Assigned";
            newGuest.pricePerNight = 0;

            guests.Add(newGuest);

            Console.WriteLine("Guest registered successfully.");
            Console.WriteLine("Guest ID: " + newGuest.guestId);
            Console.WriteLine("Guest Name: " + newGuest.guestName);
            Console.WriteLine("Check-in Date: " + newGuest.checkInDate);
            Console.WriteLine("Total Nights: " + newGuest.totalNights);
            Console.WriteLine("Room Number: " + newGuest.roomNumber);
        }

        //Case 3 — Book a Room for a Guest
        static void BookRoomForGuest(List<Room> rooms, List<Guest> guests)
        {
            Console.Write("Enter guest ID: ");
            string guestId = Console.ReadLine();

            Guest selectedGuest = guests.FirstOrDefault(guest => guest.guestId == guestId);

            if (selectedGuest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }

            Console.Write("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Room selectedRoom = rooms.FirstOrDefault(room => room.roomNumber == roomNumber);

            if (selectedRoom == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }

            if (selectedRoom.isAvailable == false)
            {
                Console.WriteLine("Room is already booked.");
                return;
            }

            selectedGuest.roomNumber = selectedRoom.roomNumber.ToString();
            selectedGuest.pricePerNight = selectedRoom.pricePerNight;

            selectedRoom.isAvailable = false;

            Console.WriteLine("Booking confirmed.");
            Console.WriteLine("Guest Name: " + selectedGuest.guestName);
            Console.WriteLine("Room Number: " + selectedRoom.roomNumber);
            Console.WriteLine("Room Type: " + selectedRoom.roomType);
            Console.WriteLine("Price Per Night: " + selectedRoom.pricePerNight.ToString("F2"));
            Console.WriteLine("Total Nights: " + selectedGuest.totalNights);
            Console.WriteLine("Total Cost: " + selectedGuest.calculateTotalCost().ToString("F2"));
        }


        //Case 04 View All Rooms
        static void ViewAllRooms(List<Room> rooms)
        {
            if (rooms.Count() == 0)
            {
                Console.WriteLine("No rooms have been added yet.");
                return;
            }

            Console.WriteLine("Total Rooms: " + rooms.Count());

            var sortedRooms = rooms.OrderBy(room => room.roomNumber).ToList();

            foreach (Room room in sortedRooms)
            {
                Console.WriteLine("----------------------");
                room.displayRoom();
            }
        }

        //Case 05 View All Guests
        static void ViewAllGuests(List<Guest> guests)
        {
            if (guests.Count() == 0)
            {
                Console.WriteLine("No guests have been registered yet.");
                return;
            }

            Console.WriteLine("Total Guests: " + guests.Count());

            var sortedGuests = guests.OrderBy(guest => guest.guestName).ToList();

            foreach (Guest guest in sortedGuests)
            {
                Console.WriteLine("----------------------");
                guest.displayGuest();
            }
        }

        //Case 06 Search & Filter Rooms
        static void SearchAndFilterRooms(List<Room> rooms)
        {
            Console.WriteLine("===== Search & Filter Rooms =====");
            Console.WriteLine("1. Show all available rooms");
            Console.WriteLine("2. Filter by room type");
            Console.WriteLine("3. Filter by max price");
            Console.WriteLine("4. Room price statistics");
            Console.WriteLine("0. Back");
            Console.Write("Choose option: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                var availableRooms = rooms
                    .Where(room => room.isAvailable == true)
                    .OrderBy(room => room.pricePerNight)
                    .ToList();

                Console.WriteLine("Available rooms count: " + availableRooms.Count());

                if (availableRooms.Count() == 0)
                {
                    Console.WriteLine("No rooms found for the selected criteria.");
                    return;
                }

                foreach (Room room in availableRooms)
                {
                    Console.WriteLine("----------------------");
                    room.displayRoom();
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter room type Single / Double / Suite: ");
                string type = Console.ReadLine();

                var filteredRooms = rooms
                    .Where(room => room.roomType.ToLower() == type.ToLower())
                    .ToList();

                Console.WriteLine("Matching rooms count: " + filteredRooms.Count());

                if (filteredRooms.Count() == 0)
                {
                    Console.WriteLine("No rooms found for the selected criteria.");
                    return;
                }

                foreach (Room room in filteredRooms)
                {
                    Console.WriteLine("----------------------");
                    room.displayRoom();
                }
            }
            else if (choice == 3)
            {
                Console.Write("Enter maximum price: ");
                double maxPrice = double.Parse(Console.ReadLine());

                var filteredRooms = rooms
                    .Where(room => room.isAvailable == true && room.pricePerNight <= maxPrice)
                    .OrderBy(room => room.pricePerNight)
                    .ToList();

                Console.WriteLine("Matching rooms count: " + filteredRooms.Count());

                if (filteredRooms.Count() == 0)
                {
                    Console.WriteLine("No rooms found for the selected criteria.");
                    return;
                }

                foreach (Room room in filteredRooms)
                {
                    Console.WriteLine("----------------------");
                    room.displayRoom();
                }
            }
            else if (choice == 4)
            {
                if (rooms.Count() == 0)
                {
                    Console.WriteLine("No rooms have been added yet.");
                    return;
                }

                int totalRooms = rooms.Count();
                int availableRooms = rooms.Count(room => room.isAvailable == true);
                double averagePrice = rooms.Average(room => room.pricePerNight);
                double cheapestPrice = rooms.Min(room => room.pricePerNight);
                double mostExpensivePrice = rooms.Max(room => room.pricePerNight);

                Console.WriteLine("Total rooms: " + totalRooms);
                Console.WriteLine("Available rooms: " + availableRooms);
                Console.WriteLine("Average price: " + averagePrice.ToString("F2"));
                Console.WriteLine("Cheapest price: " + cheapestPrice.ToString("F2"));
                Console.WriteLine("Most expensive price: " + mostExpensivePrice.ToString("F2"));
            }
            else if (choice == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        //Case 07 Guest & Booking Statistics 
        static void GuestAndBookingStatistics(List<Room> rooms, List<Guest> guests)
        {
            int totalGuests = guests.Count();
            int guestsWithBooking = guests.Count(guest => guest.roomNumber != "Not Assigned");

            int totalRooms = rooms.Count();
            int bookedRooms = rooms.Count(room => room.isAvailable == false);

            Console.WriteLine("===== Guest & Booking Statistics =====");
            Console.WriteLine("Total registered guests: " + totalGuests);
            Console.WriteLine("Guests with active booking: " + guestsWithBooking);
            Console.WriteLine("Total rooms: " + totalRooms);
            Console.WriteLine("Booked rooms: " + bookedRooms);

            var bookedGuests = guests
                .Where(guest => guest.roomNumber != "Not Assigned")
                .ToList();

            if (bookedGuests.Count() == 0)
            {
                Console.WriteLine("No active bookings recorded.");
                return;
            }

            double averageNights = bookedGuests.Average(guest => guest.totalNights);
            Console.WriteLine("Average nights for booked guests: " + averageNights.ToString("F2"));

            Console.WriteLine("===== Top 3 Highest Spending Guests =====");

            var topGuests = bookedGuests
                .OrderByDescending(guest => guest.calculateTotalCost())
                .Take(3)
                .ToList();

            foreach (Guest guest in topGuests)
            {
                Console.WriteLine("Guest Name: " + guest.guestName);
                Console.WriteLine("Room Number: " + guest.roomNumber);
                Console.WriteLine("Total Cost: OMR " + guest.calculateTotalCost().ToString("F2"));
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("===== Booked Guest Summary =====");

            var summaries = bookedGuests
                .Select(guest => guest.guestName + " — Room " + guest.roomNumber + " — " + guest.totalNights + " nights — OMR " + guest.calculateTotalCost().ToString("F2"))
                .ToList();

            foreach (string summary in summaries)
            {
                Console.WriteLine(summary);
            }
        }


        //Case 08 Update Room Price
        static void UpdateRoomPrice(List<Room> rooms)
        {
            Console.Write("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Room selectedRoom = rooms.FirstOrDefault(room => room.roomNumber == roomNumber);

            if (selectedRoom == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }

            Console.Write("Enter new price per night: ");
            double newPrice = double.Parse(Console.ReadLine());

            if (newPrice <= 0)
            {
                Console.WriteLine("Price must be positive.");
                return;
            }

            double oldPrice = selectedRoom.pricePerNight;
            selectedRoom.pricePerNight = newPrice;

            Console.WriteLine("Room price updated successfully.");
            Console.WriteLine("Old price: " + oldPrice.ToString("F2"));
            Console.WriteLine("New price: " + selectedRoom.pricePerNight.ToString("F2"));
        }

        //Case 09 Guest Lookup by Name 
        static void GuestLookupByName(List<Guest> guests)
        {
            Console.Write("Enter guest name or part of name: ");
            string searchText = Console.ReadLine();

            var matchingGuests = guests
                .Where(guest => guest.guestName.ToLower().Contains(searchText.ToLower()))
                .ToList();

            Console.WriteLine("Matches found: " + matchingGuests.Count());

            if (matchingGuests.Count() == 0)
            {
                Console.WriteLine("No guests matched that search.");
                return;
            }

            foreach (Guest guest in matchingGuests)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Guest ID: " + guest.guestId);
                Console.WriteLine("Guest Name: " + guest.guestName);
                Console.WriteLine("Room Number: " + guest.roomNumber);
            }
        }


        //Case 10 Room Type Breakdown Report
        static void RoomTypeBreakdownReport(List<Room> rooms)
        {
            if (rooms.Count() == 0)
            {
                Console.WriteLine("No rooms have been added yet.");
                return;
            }

            Console.WriteLine("===== Room Type Breakdown Report =====");

            int singleCount = rooms.Count(room => room.roomType.ToLower() == "single");
            Console.WriteLine("Single rooms count: " + singleCount);

            if (singleCount > 0)
            {
                double singleAverage = rooms
                    .Where(room => room.roomType.ToLower() == "single")
                    .Average(room => room.pricePerNight);

                Console.WriteLine("Single average price: " + singleAverage.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Single average price: N/A");
            }

            Console.WriteLine("----------------------");

            int doubleCount = rooms.Count(room => room.roomType.ToLower() == "double");
            Console.WriteLine("Double rooms count: " + doubleCount);

            if (doubleCount > 0)
            {
                double doubleAverage = rooms
                    .Where(room => room.roomType.ToLower() == "double")
                    .Average(room => room.pricePerNight);

                Console.WriteLine("Double average price: " + doubleAverage.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Double average price: N/A");
            }

            Console.WriteLine("----------------------");

            int suiteCount = rooms.Count(room => room.roomType.ToLower() == "suite");
            Console.WriteLine("Suite rooms count: " + suiteCount);

            if (suiteCount > 0)
            {
                double suiteAverage = rooms
                    .Where(room => room.roomType.ToLower() == "suite")
                    .Average(room => room.pricePerNight);

                Console.WriteLine("Suite average price: " + suiteAverage.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Suite average price: N/A");
            }

            Console.WriteLine("----------------------");

            double overallAverage = rooms.Average(room => room.pricePerNight);
            Console.WriteLine("Overall average price: " + overallAverage.ToString("F2"));
        }

        static void CheckOutGuest(List<Room> rooms, List<Guest> guests)
        {
            Console.WriteLine("Check Out Guest selected.");
        }

        static void RemoveUnavailableRooms(List<Room> rooms, List<Guest> guests)
        {
            Console.WriteLine("Remove Unavailable Rooms selected.");
        }

        static void ExtendGuestStay(List<Guest> guests)
        {
            Console.WriteLine("Extend Guest Stay selected.");
        }

        static void HighestRevenueBooking(List<Guest> guests)
        {
            Console.WriteLine("Highest Revenue Booking selected.");
        }

        static void GuestPaginationViewer(List<Guest> guests)
        {
            Console.WriteLine("Guest Pagination Viewer selected.");
        }
    }
}
