using System;
using System.Collections.Generic;
using System.Text;
using Module2Activity1.Model;


namespace Module2Activity1.ViewModel
{
    class TaskViewModel
    {
        public Taskmodel TaskModelSet { get; set; }
        public TaskViewModel()
        {
            TaskModelSet = new Taskmodel
            {
                SubjectCode = "PDC06",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3,
            };
        }
    }
}
