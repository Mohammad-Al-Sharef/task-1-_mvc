namespace task1mvc.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime ReceivedDate { get; set; }

        public Feedback(int feedbackId, string email, string message, DateTime receivedDate)
        {
            FeedbackId = feedbackId;
            Email = email;
            Message = message;
            ReceivedDate = receivedDate;
        }

        public List<Feedback> ViewFeedback()
        {
            // Code to retrieve all feedback
            return new List<Feedback>();
        }
    }
}
