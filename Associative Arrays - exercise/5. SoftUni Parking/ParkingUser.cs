namespace _5._SoftUni_Parking
{
    public class ParkingUser
    {
        public ParkingUser(string userName, string carPlate)
        {
            this.UserName = userName;
            this.CarPlate = carPlate;
        }

        public string UserName { get; set; }

        public string CarPlate { get; set; }

        public override string ToString()
        {
            return $"{UserName} => {CarPlate}";
        }
    }
}
