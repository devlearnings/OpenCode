using System.Collections.ObjectModel;
using System.Configuration;
using WPFDemo.Helper;
using WPFDemo.Model;

namespace WPFDemo.ViewModel
{
    public class UserCommentViewModel
    {
        private GenericDelegateCommand showCommentCommand;
        public GenericDelegateCommand ShowCommentCommand { get; set; }

        #region Property
        private string comment;
        public string Comment
        {
            get => comment;
            set
            {
                comment = value;
                ShowCommentCommand.RaiseCanExecuteChange();
            }
        }
        #endregion

        #region Data Source

        public ObservableCollection<UserComment> Comments => LstComment;
        private ObservableCollection<UserComment> LstComment;
        #endregion

        public UserCommentViewModel()
        {
            LstComment = new ObservableCollection<UserComment>();
            ShowCommentCommand = new GenericDelegateCommand(CanExecuteShowComment, ExecuteShowComment);
        }

        private void ExecuteShowComment(object parameter)
        {
            LstComment.Add(new UserComment { Comment = this.comment });
            this.Comment = string.Empty;
        }

        private bool CanExecuteShowComment(object parameter)
        {
            return !string.IsNullOrWhiteSpace(comment);
        }

    }
}
