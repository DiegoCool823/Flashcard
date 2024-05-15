
namespace Flashcard.Services.Notifications
{
    public interface INotificationService
    {
        Type PageSource { get; set; }

        event EventHandler<Type> OnTargetUpdated;

        void ChangeMainArea(Type targetPage);
    }
}