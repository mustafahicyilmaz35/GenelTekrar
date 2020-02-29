using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RepeatLesson.Droid;

[assembly:Xamarin.Forms.Dependency(typeof(VideoPicker))]
namespace RepeatLesson.Droid
{
    public class VideoPicker : IVideoPicker
    {
        public Task<string> GetVideoFileAsync()
        {
            Intent intent = new Intent();
            intent.SetType("video/*");
            intent.SetAction(Intent.ActionGetContent);

            MainActivity activity = MainActivity.Current;

            activity.StartActivityForResult(Intent.CreateChooser(intent, "SelectVideo"), MainActivity.PickImageId);

            // Save the TaskCompletionSource object as a MainActivity property;
            activity.PickImageTaskCompletionSource = new TaskCompletionSource<string>();

            // Return Task object
            return activity.PickImageTaskCompletionSource.Task;

        }
    }
}