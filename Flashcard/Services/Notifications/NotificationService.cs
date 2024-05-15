namespace Flashcard.Services.Notifications
{
    public class NotificationService : INotificationService
    {
        public Type PageSource { get; set; }

        public event EventHandler<Type> OnTargetUpdated;

        public void ChangeMainArea(Type targetPage)
        {
            PageSource = targetPage;
            OnTargetUpdated?.Invoke(this, PageSource);
        }
    }
}
