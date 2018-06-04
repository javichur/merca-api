namespace API_merca.Classes
{
    public class PriceInstructionsClass
    {
        public int iva { get; set; }
        public bool is_new { get; set; }
        public bool is_pack { get; set; }
        public float? pack_size { get; set; }
        public string unit_name { get; set; }
        public float? unit_size { get; set; }
        public float bulk_price { get; set; }
        public float unit_price { get; set; }
        public bool approx_size { get; set; }
        public string size_format { get; set; }
        public float? total_units { get; set; }
        public bool unit_selector { get; set; }
        public bool bunch_selector { get; set; }
        public float? drained_weight { get; set; }
        public bool price_decreased { get; set; }
        public float reference_price { get; set; }
        public float min_bunch_amount { get; set; }
        public string reference_format { get; set; }
        public float? previous_bulk_price { get; set; }
        public float? previous_unit_price { get; set; }
        public float increment_bunch_amount { get; set; }
    }
}