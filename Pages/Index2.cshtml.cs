using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Device.Gpio;

namespace MyApp.Namespace
{
    public class Index2Model : PageModel
    {
        private GpioController controller;

        public Index2Model(GpioController controller)
        {
            this.controller=controller;
        }
        public void OnGet()
        {
        }
        [BindProperty]
        public bool Output1 {get; set;}
        [BindProperty]
        public bool Output2 {get; set;}
        [BindProperty]
        public bool Output3 {get; set;}

        public void OnPost()
        {
            Console.WriteLine($"Output 1 is {Output1}");
            controller.Write(17, Output1 ? PinValue.High : PinValue.Low);
            Console.WriteLine($"Output 2 is {Output2}");
            controller.Write(22, Output2 ? PinValue.High : PinValue.Low);
            Console.WriteLine($"Output 3 is {Output3}");
            controller.Write(27, Output3 ? PinValue.High : PinValue.Low);

        }

    }
}
