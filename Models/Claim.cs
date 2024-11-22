namespace P3CMCS.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string LecturerId { get; set; }
        public string LecturerName { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal Rate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }

        // Calculated property for TotalAmount
        public decimal TotalAmount => HoursWorked * Rate; // Auto-calculation
    }
}