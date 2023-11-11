using Book.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Presenters
{
    public class StoryPresenter
    {
        private IStoryView view;

        public StoryPresenter(IStoryView view)
        {
            this.view = view;
            this.view.Show();
        }
    }
}
