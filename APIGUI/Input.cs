using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIGUI {
    public enum QueryParameter {
        Date,
        Count,
        StartEndDate,
        //Thumbs
    }
    public class Input {
        public string date { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public int count { get; set; }
        public QueryParameter parameter { get; set; }


        public Input LoadInput(Form1 form) {
            Input input = new Input();
            if (form.QueryTypeBox.SelectedItem == "Date") {
                input.date = form.FirstParameter.Text;
                input.parameter = QueryParameter.Date;
            } else if (form.QueryTypeBox.SelectedItem == "Date Range") {
                input.parameter = QueryParameter.StartEndDate;
                input.start_date = form.FirstParameter.Text;
                input.end_date = form.SecondParameter.Text;
            } else if (form.QueryTypeBox.SelectedItem == "Count") {
                input.parameter = QueryParameter.Count;
                input.count = Convert.ToInt32(form.FirstParameter.Text);
            }
            return input;
        }

    }
}
