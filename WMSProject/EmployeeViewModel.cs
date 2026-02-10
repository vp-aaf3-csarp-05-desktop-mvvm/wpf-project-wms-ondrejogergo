namespace WMSProject
{
    /// <summary>
    /// Dolgozó adatok megjelenítéshez (szabadnapkezelés)
    /// </summary>
    public class EmployeeViewModel
    {
        /// <summary>
        /// Dolgozó neve
        /// </summary>
        public string Name { get; } = "Nagy Anna";

        /// <summary>
        /// Dolgozó adószáma
        /// </summary>
        public string TaxNumber { get; } = "12345678-9-10";

        /// <summary>
        /// Dolgozó kivett szabadnapjainak száma
        /// </summary>
        public int DaysOff { get; } = 15;
    }
}