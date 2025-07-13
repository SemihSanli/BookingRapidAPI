namespace RapidApiBooking.ConsumeModels
{
    public class FlyViewModels
    {
        public int FlyId { get; set; }
        public string name { get; set; }
        public string DepartureDate { get; set; }
        public string ReturnDate { get; set; }
        public string CabinClass { get; set; }
    }
}

public class Rootobject
{
    public Data data { get; set; }
    public bool status { get; set; }
    public string message { get; set; }
}

public class Data
{
    public int b_legal_use_neutral_color_for_persuasion_legal { get; set; }
    public int max_rooms_in_reservation { get; set; }
    public Languages_Spoken languages_spoken { get; set; }
    public string accommodation_type_name { get; set; }
    public string cvc_required { get; set; }
    public int use_new_bui_icon_highlight { get; set; }
    public Breakfast_Review_Score breakfast_review_score { get; set; }
    public string hotel_address_line { get; set; }
    public int b_sca_flow_property_user_ip { get; set; }
    public string city { get; set; }
    public object[] family_facilities { get; set; }
    public object[] tax_exceptions { get; set; }
    public int district_id { get; set; }
    public int is_exclusive { get; set; }
    public float distance_to_cc { get; set; }
    public string default_wishlist_name { get; set; }
    public Property_Highlight_Strip_Saba property_highlight_strip_saba { get; set; }
    public string hotel_name { get; set; }
    public string default_language { get; set; }
    public int is_closed { get; set; }
    public Aggregated_Data aggregated_data { get; set; }
    public string payment_product { get; set; }
    public string plq_sensitivity { get; set; }
    public Direct_Payment direct_payment { get; set; }
    public int is_hotel_ctrip { get; set; }
    public string address_trans { get; set; }
    public string arrival_date { get; set; }
    public int is_in_real_heart { get; set; }
    public Trip_Types_Extra[] trip_types_extra { get; set; }
    public int cant_book { get; set; }
    public Hotel_Text hotel_text { get; set; }
    public Property_Highlight_Strip[] property_highlight_strip { get; set; }
    public string[] spoken_languages { get; set; }
    public string city_trans { get; set; }
    public Composite_Price_Breakdown composite_price_breakdown { get; set; }
    public string has_theme_park_benefits { get; set; }
    public Wifi_Review_Score wifi_review_score { get; set; }
    public int total_blocks { get; set; }
    public Block[] block { get; set; }
    public int hotel_id { get; set; }
    public string cc1 { get; set; }
    public int is_city_center { get; set; }
    public Booking_Home booking_home { get; set; }
    public int seen_cc_app_rp_missing_fac { get; set; }
    public float longitude { get; set; }
    public string countrycode { get; set; }
    public Tpi_Block[] tpi_block { get; set; }
    public int available_rooms { get; set; }
    public string rare_find_state { get; set; }
    public string city_in_trans { get; set; }
    public int is_family_friendly { get; set; }
    public int soldout { get; set; }
    public object[] preferences { get; set; }
    public int ufi { get; set; }
    public string country_trans { get; set; }
    public string hotel_facilities { get; set; }
    public int genius_rates_can_be_available { get; set; }
    public Top_Ufi_Benefits[] top_ufi_benefits { get; set; }
    public int is_preferred_plus { get; set; }
    public int review_nr { get; set; }
    public int address_required { get; set; }
    public int seen_cc_app_hp_missing_info { get; set; }
    public string generated_property_title { get; set; }
    public string currency_code { get; set; }
    public int block_count { get; set; }
    public int is_cash_accepted_check_enabled { get; set; }
    public int[] districts { get; set; }
    public int accommodation_type { get; set; }
    public Min_Room_Distribution min_room_distribution { get; set; }
    public B_Max_Los_Data b_max_los_data { get; set; }
    public float latitude { get; set; }
    public string urgency_room_string { get; set; }
    public Payment_Detail payment_detail { get; set; }
    public int b_blackout_android_prepayment_copy { get; set; }
    public Rooms rooms { get; set; }
    public string zip { get; set; }
    public object district { get; set; }
    public int mobile_discount_percentage { get; set; }
    public string address { get; set; }
    public Only_X_Left only_x_left { get; set; }
    public string wl_dest_id { get; set; }
    public int check_only_x_left { get; set; }
    public string url { get; set; }
    public int is_tpi_exclusive_property { get; set; }
    public int is_cpv2_property { get; set; }
    public int is_vp2_enrolled { get; set; }
    public int is_preferred { get; set; }
    public int is_crimea { get; set; }
    public string recommended_block_title { get; set; }
    public Tpi_Composite_Price_Breakdown tpi_composite_price_breakdown { get; set; }
    public string average_room_size_for_ufi_m2 { get; set; }
    public int hotel_include_breakfast { get; set; }
    public Last_Reservation last_reservation { get; set; }
    public string city_name_en { get; set; }
    public Facilities_Block facilities_block { get; set; }
    public string hotel_name_trans { get; set; }
    public string cc_required { get; set; }
    public string timezone { get; set; }
    public int class_is_estimated { get; set; }
    public int qualifies_for_no_cc_reservation { get; set; }
    public Property_Policy_Display_Details property_policy_display_details { get; set; }
    public int is_eligible_for_horizontal_scroll { get; set; }
    public string departure_date { get; set; }
    public int duplicate_rates_removed { get; set; }
    public Room_Recommendation[] room_recommendation { get; set; }
}

public class Languages_Spoken
{
    public string[] languagecode { get; set; }
}

public class Breakfast_Review_Score
{
    public string review_snippet { get; set; }
    public int review_count { get; set; }
    public int review_score { get; set; }
    public string review_score_word { get; set; }
    public int review_number { get; set; }
    public int rating { get; set; }
}

public class Property_Highlight_Strip_Saba
{
    public Trackedexperiment[] trackedExperiments { get; set; }
    public int serverVersion { get; set; }
    public int clientVersion { get; set; }
    public string mfeId { get; set; }
    public Root root { get; set; }
}

public class Root
{
    public Props props { get; set; }
    public string type { get; set; }
}

public class Props
{
    public Component component { get; set; }
    public string direction { get; set; }
}

public class Component
{
    public string type { get; set; }
    public Props1 props { get; set; }
}

public class Props1
{
    public Item[] items { get; set; }
}

public class Item
{
    public string type { get; set; }
    public Props2 props { get; set; }
}

public class Props2
{
    public Component1 component { get; set; }
    public Margin3 margin { get; set; }
    public Action[] actions { get; set; }
}

public class Component1
{
    public string type { get; set; }
    public Props3 props { get; set; }
}

public class Props3
{
    public bool fitContentWidth { get; set; }
    public Item2[] items { get; set; }
    public string alignment { get; set; }
    public string spacing { get; set; }
    public Margin margin { get; set; }
    public Component2 component { get; set; }
}

public class Margin
{
    public string bottom { get; set; }
    public string start { get; set; }
    public string end { get; set; }
    public string top { get; set; }
}

public class Component2
{
    public Props4 props { get; set; }
    public string type { get; set; }
}

public class Props4
{
    public bool fitContentWidth { get; set; }
    public Item1[] items { get; set; }
    public string spacing { get; set; }
    public string alignment { get; set; }
}

public class Item1
{
    public string type { get; set; }
    public Props5 props { get; set; }
}

public class Props5
{
    public Component3 component { get; set; }
    public Margin1 margin { get; set; }
    public string text { get; set; }
    public int lines { get; set; }
    public string color { get; set; }
    public string font { get; set; }
    public string alignment { get; set; }
}

public class Component3
{
    public Props6 props { get; set; }
    public string type { get; set; }
}

public class Props6
{
    public string background { get; set; }
    public string tintColor { get; set; }
    public string size { get; set; }
    public string content { get; set; }
}

public class Margin1
{
    public string top { get; set; }
}

public class Item2
{
    public Props7 props { get; set; }
    public string type { get; set; }
}

public class Props7
{
    public Margin2 margin { get; set; }
    public Component4 component { get; set; }
    public int lines { get; set; }
    public string text { get; set; }
    public string alignment { get; set; }
    public string font { get; set; }
    public int maxWidth { get; set; }
}

public class Margin2
{
    public string top { get; set; }
}

public class Component4
{
    public string type { get; set; }
    public Props8 props { get; set; }
}

public class Props8
{
    public string content { get; set; }
    public string size { get; set; }
    public string background { get; set; }
    public int lines { get; set; }
    public string text { get; set; }
    public string font { get; set; }
    public string alignment { get; set; }
}

public class Margin3
{
    public string end { get; set; }
    public string start { get; set; }
    public string top { get; set; }
    public string bottom { get; set; }
}

public class Action
{
    public string type { get; set; }
    public Props9 props { get; set; }
}

public class Props9
{
    public Experiment experiment { get; set; }
    public int goalIndex { get; set; }
    public string url { get; set; }
}

public class Experiment
{
    public int variant { get; set; }
    public string name { get; set; }
    public string uvi { get; set; }
    public bool shouldTrack { get; set; }
    public string id { get; set; }
    public string uviType { get; set; }
}

public class Trackedexperiment
{
    public int variant { get; set; }
    public string name { get; set; }
    public string uvi { get; set; }
    public bool shouldTrack { get; set; }
    public string id { get; set; }
    public string uviType { get; set; }
}

public class Aggregated_Data
{
    public int has_nonrefundable { get; set; }
    public int has_seating { get; set; }
    public int has_kitchen { get; set; }
    public object[] common_kitchen_fac { get; set; }
    public int has_refundable { get; set; }
}

public class Direct_Payment
{
    public int is_hpp_only { get; set; }
}

public class Hotel_Text
{
}

public class Composite_Price_Breakdown
{
    public Charges_Details charges_details { get; set; }
    public All_Inclusive_Amount all_inclusive_amount { get; set; }
    public int has_long_stays_monthly_rate_price { get; set; }
    public Gross_Amount_Per_Night gross_amount_per_night { get; set; }
    public All_Inclusive_Amount_Hotel_Currency all_inclusive_amount_hotel_currency { get; set; }
    public Strikethrough_Amount strikethrough_amount { get; set; }
    public Benefit[] benefits { get; set; }
    public Strikethrough_Amount_Per_Night strikethrough_amount_per_night { get; set; }
    public Excluded_Amount excluded_amount { get; set; }
    public int has_long_stays_weekly_rate_price { get; set; }
    public Included_Taxes_And_Charges_Amount included_taxes_and_charges_amount { get; set; }
    public Discounted_Amount discounted_amount { get; set; }
    public Gross_Amount gross_amount { get; set; }
    public Gross_Amount_Hotel_Currency gross_amount_hotel_currency { get; set; }
    public Price_Display_Config[] price_display_config { get; set; }
    public Net_Amount net_amount { get; set; }
    public Item3[] items { get; set; }
}

public class Charges_Details
{
    public string translated_copy { get; set; }
    public string mode { get; set; }
    public Amount amount { get; set; }
}

public class Amount
{
    public int value { get; set; }
    public string currency { get; set; }
}

public class All_Inclusive_Amount
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Gross_Amount_Per_Night
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class All_Inclusive_Amount_Hotel_Currency
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Strikethrough_Amount
{
    public string amount_unrounded { get; set; }
    public int value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Strikethrough_Amount_Per_Night
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Excluded_Amount
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Included_Taxes_And_Charges_Amount
{
    public string currency { get; set; }
    public string amount_rounded { get; set; }
    public string amount_unrounded { get; set; }
    public int value { get; set; }
}

public class Discounted_Amount
{
    public string currency { get; set; }
    public string amount_rounded { get; set; }
    public string amount_unrounded { get; set; }
    public float value { get; set; }
}

public class Gross_Amount
{
    public string currency { get; set; }
    public string amount_rounded { get; set; }
    public string amount_unrounded { get; set; }
    public float value { get; set; }
}

public class Gross_Amount_Hotel_Currency
{
    public string currency { get; set; }
    public string amount_rounded { get; set; }
    public string amount_unrounded { get; set; }
    public float value { get; set; }
}

public class Net_Amount
{
    public float value { get; set; }
    public string amount_unrounded { get; set; }
    public string amount_rounded { get; set; }
    public string currency { get; set; }
}

public class Benefit
{
    public string badge_variant { get; set; }
    public object icon { get; set; }
    public string name { get; set; }
    public string identifier { get; set; }
    public string details { get; set; }
    public string kind { get; set; }
}

public class Price_Display_Config
{
    public int value { get; set; }
    public string key { get; set; }
}

public class Item3
{
    public Item_Amount item_amount { get; set; }
    public string kind { get; set; }
    public string details { get; set; }
    public string name { get; set; }
    public string inclusion_type { get; set; }
    public Base _base { get; set; }
    public string identifier { get; set; }
}

public class Item_Amount
{
    public float value { get; set; }
    public string amount_unrounded { get; set; }
    public string amount_rounded { get; set; }
    public string currency { get; set; }
}

public class Base
{
    public string kind { get; set; }
    public float percentage { get; set; }
    public float base_amount { get; set; }
}

public class Wifi_Review_Score
{
    public float rating { get; set; }
}

public class Booking_Home
{
}

public class Min_Room_Distribution
{
    public object[] children { get; set; }
    public int adults { get; set; }
}

public class B_Max_Los_Data
{
    public int extended_los { get; set; }
    public int has_extended_los { get; set; }
    public int is_fullon { get; set; }
    public string experiment { get; set; }
    public int default_los { get; set; }
    public int max_allowed_los { get; set; }
}

public class Payment_Detail
{
    public string model { get; set; }
}

public class Rooms
{
    public _5616602 _5616602 { get; set; }
}

public class _5616602
{
    public int private_bathroom_count { get; set; }
    public Bed_Configurations[] bed_configurations { get; set; }
    public Children_And_Beds_Text children_and_beds_text { get; set; }
    public Facility[] facilities { get; set; }
    public string description { get; set; }
    public object apartment_configuration { get; set; }
    public Photo[] photos { get; set; }
    public Private_Bathroom_Highlight private_bathroom_highlight { get; set; }
    public Highlight[] highlights { get; set; }
}

public class Children_And_Beds_Text
{
    public Cribs_And_Extra_Beds[] cribs_and_extra_beds { get; set; }
    public Children_At_The_Property[] children_at_the_property { get; set; }
    public int allow_children { get; set; }
    public object[] age_intervals { get; set; }
}

public class Cribs_And_Extra_Beds
{
    public string text { get; set; }
    public int highlight { get; set; }
}

public class Children_At_The_Property
{
    public int highlight { get; set; }
    public string text { get; set; }
}

public class Private_Bathroom_Highlight
{
    public int has_highlight { get; set; }
}

public class Bed_Configurations
{
    public Bed_Types[] bed_types { get; set; }
}

public class Bed_Types
{
    public string description { get; set; }
    public string name_with_count { get; set; }
    public int bed_type { get; set; }
    public string description_imperial { get; set; }
    public object description_localized { get; set; }
    public string name { get; set; }
    public int count { get; set; }
}

public class Facility
{
    public int id { get; set; }
    public int facilitytype_id { get; set; }
    public string name { get; set; }
    public string alt_facilitytype_name { get; set; }
    public int alt_facilitytype_id { get; set; }
}

public class Photo
{
    public int photo_id { get; set; }
    public string url_square60 { get; set; }
    public string url_max300 { get; set; }
    public string url_original { get; set; }
    public string last_update_date { get; set; }
    public string url_640x200 { get; set; }
    public float ratio { get; set; }
}

public class Highlight
{
    public string icon { get; set; }
    public string translated_name { get; set; }
    public int id { get; set; }
}

public class Only_X_Left
{
    public Rooms_List rooms_list { get; set; }
    public Post_Select post_select { get; set; }
    public Microfunnel_Rooms_List microfunnel_rooms_list { get; set; }
    public Room_Page room_page { get; set; }
    public Microfunnel_Rate_Selection microfunnel_rate_selection { get; set; }
}

public class Rooms_List
{
    public string _5616602_371662184_2_0_0 { get; set; }
}

public class Post_Select
{
    public string _5616602_371662184_2_0_0 { get; set; }
}

public class Microfunnel_Rooms_List
{
    public string _5616602 { get; set; }
}

public class Room_Page
{
    public string _5616602_371662184_2_0_0 { get; set; }
}

public class Microfunnel_Rate_Selection
{
}

public class Tpi_Composite_Price_Breakdown
{
    public Gross_Amount_Per_Night1 gross_amount_per_night { get; set; }
    public object[] benefits { get; set; }
    public All_Inclusive_Amount_Hotel_Currency1 all_inclusive_amount_hotel_currency { get; set; }
    public int has_long_stays_monthly_rate_price { get; set; }
    public All_Inclusive_Amount1 all_inclusive_amount { get; set; }
    public Charges_Details1 charges_details { get; set; }
    public Gross_Amount_Hotel_Currency1 gross_amount_hotel_currency { get; set; }
    public Gross_Amount1 gross_amount { get; set; }
    public int has_long_stays_weekly_rate_price { get; set; }
    public Included_Taxes_And_Charges_Amount1 included_taxes_and_charges_amount { get; set; }
    public Excluded_Amount1 excluded_amount { get; set; }
    public Item4[] items { get; set; }
    public Price_Display_Config1[] price_display_config { get; set; }
    public Net_Amount1 net_amount { get; set; }
}

public class Gross_Amount_Per_Night1
{
    public float value { get; set; }
    public string amount_unrounded { get; set; }
    public string amount_rounded { get; set; }
    public string currency { get; set; }
}

public class All_Inclusive_Amount_Hotel_Currency1
{
    public string currency { get; set; }
    public string amount_rounded { get; set; }
    public string amount_unrounded { get; set; }
    public float value { get; set; }
}

public class All_Inclusive_Amount1
{
    public string currency { get; set; }
    public string amount_rounded { get; set; }
    public string amount_unrounded { get; set; }
    public float value { get; set; }
}

public class Charges_Details1
{
    public string mode { get; set; }
    public Amount1 amount { get; set; }
    public string translated_copy { get; set; }
}

public class Amount1
{
    public int value { get; set; }
    public string currency { get; set; }
}

public class Gross_Amount_Hotel_Currency1
{
    public float value { get; set; }
    public string amount_unrounded { get; set; }
    public string amount_rounded { get; set; }
    public string currency { get; set; }
}

public class Gross_Amount1
{
    public float value { get; set; }
    public string amount_unrounded { get; set; }
    public string amount_rounded { get; set; }
    public string currency { get; set; }
}

public class Included_Taxes_And_Charges_Amount1
{
    public int value { get; set; }
    public string amount_unrounded { get; set; }
    public string amount_rounded { get; set; }
    public string currency { get; set; }
}

public class Excluded_Amount1
{
    public string amount_rounded { get; set; }
    public string currency { get; set; }
    public float value { get; set; }
    public string amount_unrounded { get; set; }
}

public class Net_Amount1
{
    public float value { get; set; }
    public string amount_unrounded { get; set; }
    public string amount_rounded { get; set; }
    public string currency { get; set; }
}

public class Item4
{
    public Item_Amount1 item_amount { get; set; }
    public object details { get; set; }
    public string kind { get; set; }
    public Base1 _base { get; set; }
    public string inclusion_type { get; set; }
    public string name { get; set; }
}

public class Item_Amount1
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Base1
{
    public string kind { get; set; }
    public float base_amount { get; set; }
}

public class Price_Display_Config1
{
    public string key { get; set; }
    public int value { get; set; }
}

public class Last_Reservation
{
    public string time { get; set; }
    public object countrycode { get; set; }
    public object country { get; set; }
}

public class Facilities_Block
{
    public string type { get; set; }
    public string name { get; set; }
    public Facility1[] facilities { get; set; }
}

public class Facility1
{
    public string icon { get; set; }
    public string name { get; set; }
}

public class Property_Policy_Display_Details
{
    public object legal_cases { get; set; }
}

public class Trip_Types_Extra
{
    public string title { get; set; }
    public string text { get; set; }
    public string id { get; set; }
}

public class Property_Highlight_Strip
{
    public Icon_List[] icon_list { get; set; }
    public string name { get; set; }
}

public class Icon_List
{
    public string icon { get; set; }
    public int size { get; set; }
}

public class Block
{
    public int genius_discount_percentage { get; set; }
    public int is_domestic_rate { get; set; }
    public int babycots_available { get; set; }
    public int all_inclusive { get; set; }
    public int refundable { get; set; }
    public string room_name { get; set; }
    public object[] bh_room_highlights { get; set; }
    public int number_of_bathrooms { get; set; }
    public int lunch_included { get; set; }
    public int roomtype_id { get; set; }
    public int can_reserve_free_parking { get; set; }
    public int is_last_minute_deal { get; set; }
    public int nr_adults { get; set; }
    public int max_children_free { get; set; }
    public float room_surface_in_feet2 { get; set; }
    public Fit_Occupancy fit_occupancy { get; set; }
    public string block_id { get; set; }
    public string name_without_policy { get; set; }
    public int is_flash_deal { get; set; }
    public Block_Text block_text { get; set; }
    public int is_mobile_deal { get; set; }
    public int max_children_free_age { get; set; }
    public int deposit_required { get; set; }
    public int smoking { get; set; }
    public Paymentterms paymentterms { get; set; }
    public string max_occupancy { get; set; }
    public Detail_Mealplan[] detail_mealplan { get; set; }
    public object extrabed_available_amount { get; set; }
    public int room_surface_in_m2 { get; set; }
    public string name { get; set; }
    public string is_block_fit { get; set; }
    public int is_smart_deal { get; set; }
    public int fit_status { get; set; }
    public Product_Price_Breakdown product_price_breakdown { get; set; }
    public int breakfast_included { get; set; }
    public int full_board { get; set; }
    public object is_genius_deal { get; set; }
    public int is_dormitory { get; set; }
    public int must_reserve_free_parking { get; set; }
    public int nr_children { get; set; }
    public int pod_ios_migrate_policies_to_smp_fullon { get; set; }
    public object babycots_available_amount { get; set; }
    public int pay_in_advance { get; set; }
    public string mealplan { get; set; }
    public object[] children_ages { get; set; }
    public string refundable_until { get; set; }
    public int dinner_included { get; set; }
    public int package_id { get; set; }
    public int half_board { get; set; }
    public int number_of_bedrooms { get; set; }
    public int extrabed_available { get; set; }
    public int room_count { get; set; }
    public int is_vp2_enrolled { get; set; }
    public int room_id { get; set; }
    public object[] b_bsb_campaigns { get; set; }
}

public class Fit_Occupancy
{
    public int nr_adults { get; set; }
    public object[] children_ages { get; set; }
}

public class Block_Text
{
    public Policy[] policies { get; set; }
}

public class Policy
{
    public string _class { get; set; }
    public string content { get; set; }
}

public class Paymentterms
{
    public Cancellation cancellation { get; set; }
    public Prepayment prepayment { get; set; }
}

public class Cancellation
{
    public string bucket { get; set; }
    public string type { get; set; }
    public string description { get; set; }
    public Info info { get; set; }
    public string type_translation { get; set; }
    public int guaranteed_non_refundable { get; set; }
    public int non_refundable_anymore { get; set; }
}

public class Info
{
    public object date { get; set; }
    public object time_before_midnight { get; set; }
    public object timezone { get; set; }
    public object timezone_offset { get; set; }
    public object date_raw { get; set; }
    public int refundable { get; set; }
    public object time { get; set; }
    public object is_midnight { get; set; }
    public object date_before_raw { get; set; }
    public object date_before { get; set; }
    public object refundable_date { get; set; }
}

public class Prepayment
{
    public Info1 info { get; set; }
    public string type_extended { get; set; }
    public string type_translation { get; set; }
    public string type { get; set; }
    public string description { get; set; }
    public string extended_type_translation { get; set; }
    public string simple_translation { get; set; }
}

public class Info1
{
    public object time { get; set; }
    public object is_midnight { get; set; }
    public int prepayment_at_booktime { get; set; }
    public object time_before_midnight { get; set; }
    public object date_before { get; set; }
    public object timezone { get; set; }
    public object timezone_offset { get; set; }
    public int refundable { get; set; }
    public object date { get; set; }
}

public class Product_Price_Breakdown
{
    public Gross_Amount_Hotel_Currency2 gross_amount_hotel_currency { get; set; }
    public Discounted_Amount1 discounted_amount { get; set; }
    public Gross_Amount2 gross_amount { get; set; }
    public int has_long_stays_weekly_rate_price { get; set; }
    public Included_Taxes_And_Charges_Amount2 included_taxes_and_charges_amount { get; set; }
    public Excluded_Amount2 excluded_amount { get; set; }
    public Item5[] items { get; set; }
    public Price_Display_Config2[] price_display_config { get; set; }
    public Net_Amount2 net_amount { get; set; }
    public int nr_stays { get; set; }
    public Strikethrough_Amount_Per_Night1 strikethrough_amount_per_night { get; set; }
    public Gross_Amount_Per_Night2 gross_amount_per_night { get; set; }
    public Benefit1[] benefits { get; set; }
    public Strikethrough_Amount1 strikethrough_amount { get; set; }
    public All_Inclusive_Amount_Hotel_Currency2 all_inclusive_amount_hotel_currency { get; set; }
    public All_Inclusive_Amount2 all_inclusive_amount { get; set; }
    public int has_long_stays_monthly_rate_price { get; set; }
    public Charges_Details2 charges_details { get; set; }
}

public class Gross_Amount_Hotel_Currency2
{
    public string amount_rounded { get; set; }
    public string currency { get; set; }
    public float value { get; set; }
    public string amount_unrounded { get; set; }
}

public class Discounted_Amount1
{
    public string amount_rounded { get; set; }
    public string currency { get; set; }
    public float value { get; set; }
    public string amount_unrounded { get; set; }
}

public class Gross_Amount2
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Included_Taxes_And_Charges_Amount2
{
    public string currency { get; set; }
    public string amount_rounded { get; set; }
    public string amount_unrounded { get; set; }
    public int value { get; set; }
}

public class Excluded_Amount2
{
    public float value { get; set; }
    public string amount_unrounded { get; set; }
    public string amount_rounded { get; set; }
    public string currency { get; set; }
}

public class Net_Amount2
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Strikethrough_Amount_Per_Night1
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Gross_Amount_Per_Night2
{
    public string currency { get; set; }
    public string amount_rounded { get; set; }
    public string amount_unrounded { get; set; }
    public float value { get; set; }
}

public class Strikethrough_Amount1
{
    public string amount_rounded { get; set; }
    public string currency { get; set; }
    public int value { get; set; }
    public string amount_unrounded { get; set; }
}

public class All_Inclusive_Amount_Hotel_Currency2
{
    public string amount_rounded { get; set; }
    public string currency { get; set; }
    public float value { get; set; }
    public string amount_unrounded { get; set; }
}

public class All_Inclusive_Amount2
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Charges_Details2
{
    public string mode { get; set; }
    public Amount2 amount { get; set; }
    public string translated_copy { get; set; }
}

public class Amount2
{
    public string currency { get; set; }
    public int value { get; set; }
}

public class Item5
{
    public Item_Amount2 item_amount { get; set; }
    public string kind { get; set; }
    public string details { get; set; }
    public string inclusion_type { get; set; }
    public string name { get; set; }
    public Base2 _base { get; set; }
    public string identifier { get; set; }
}

public class Item_Amount2
{
    public float value { get; set; }
    public string amount_unrounded { get; set; }
    public string amount_rounded { get; set; }
    public string currency { get; set; }
}

public class Base2
{
    public float percentage { get; set; }
    public string kind { get; set; }
    public float base_amount { get; set; }
}

public class Price_Display_Config2
{
    public int value { get; set; }
    public string key { get; set; }
}

public class Benefit1
{
    public string details { get; set; }
    public string kind { get; set; }
    public string badge_variant { get; set; }
    public object icon { get; set; }
    public string name { get; set; }
    public string identifier { get; set; }
}

public class Detail_Mealplan
{
    public string title { get; set; }
}

public class Tpi_Block
{
    public string rate_key { get; set; }
    public object geo_restriction { get; set; }
    public int is_instant { get; set; }
    public string book_token { get; set; }
    public int cancel_policy { get; set; }
    public int hide_no_invoice { get; set; }
    public Extra_Bed_Info extra_bed_info { get; set; }
    public int facilities_count { get; set; }
    public int[] current_cancel_policies { get; set; }
    public object tpi_list_info { get; set; }
    public int room_count { get; set; }
    public Policy_Display_Details policy_display_details { get; set; }
    public Tpi_Bp_Info tpi_bp_info { get; set; }
    public string room_id { get; set; }
    public int has_breakfast { get; set; }
    public int has_dinner { get; set; }
    public int has_lunch { get; set; }
    public string supplier_name { get; set; }
    public Bed_Configurations1[] bed_configurations { get; set; }
    public int guest_count { get; set; }
    public Restrictions restrictions { get; set; }
    public int room_type_id { get; set; }
    public Photo1[] photos { get; set; }
    public object[] children_ages { get; set; }
    public int remaining_rooms { get; set; }
    public string ws_code { get; set; }
    public string unit_configuration_label { get; set; }
    public int has_room_name { get; set; }
    public int mapped_booking_room_id { get; set; }
    public Paymentterms1 paymentterms { get; set; }
    public string tpi_block_id { get; set; }
    public int room_surface_in_m2 { get; set; }
    public Highlight1[] highlights { get; set; }
    public object tpi_room_info { get; set; }
    public object price_difference_percentage { get; set; }
    public string name { get; set; }
    public Product_Price_Breakdown1 product_price_breakdown { get; set; }
    public int inventory_owner_condition { get; set; }
    public int supplier_id { get; set; }
    public int occupancy { get; set; }
    public int confirmation_time_delay_in_minutes { get; set; }
    public int ws_id { get; set; }
    public object show_above_booking_block { get; set; }
    public string is_bigger_than_average { get; set; }
    public Min_Price min_price { get; set; }
    public int children_count { get; set; }
    public string block_id { get; set; }
    public int room_surface_in_feet2 { get; set; }
    public Facility2[] facilities { get; set; }
}

public class Extra_Bed_Info
{
    public int normal_bed_count { get; set; }
    public int extra_bed_count { get; set; }
}

public class Policy_Display_Details
{
    public Cancellation1 cancellation { get; set; }
}

public class Cancellation1
{
    public Clarification_Details clarification_details { get; set; }
    public Title_Details title_details { get; set; }
    public string policy_type_key { get; set; }
    public Description_Details description_details { get; set; }
}

public class Clarification_Details
{
    public object translation { get; set; }
    public Parameters parameters { get; set; }
    public object placeholder_translation { get; set; }
}

public class Parameters
{
    public string timezone { get; set; }
    public DateTime date { get; set; }
}

public class Title_Details
{
    public Parameters1 parameters { get; set; }
    public int has_html { get; set; }
    public string placeholder_translation { get; set; }
    public string translation { get; set; }
}

public class Parameters1
{
    public DateTime free_cancellation_deadline { get; set; }
    public string timezone { get; set; }
}

public class Description_Details
{
    public string translation { get; set; }
    public string placeholder_translation { get; set; }
}

public class Tpi_Bp_Info
{
    public string start_screen { get; set; }
    public Screen[] screens { get; set; }
    public string last_screen { get; set; }
}

public class Screen
{
    public string screen_id { get; set; }
    public Cta cta { get; set; }
    public Component5[] components { get; set; }
    public int screen_type { get; set; }
}

public class Cta
{
    public string next_screen { get; set; }
}

public class Component5
{
    public string id { get; set; }
    public Cta1[] ctas { get; set; }
}

public class Cta1
{
    public Action1 action { get; set; }
}

public class Action1
{
    public string screen_id { get; set; }
}

public class Restrictions
{
    public Bad_Words_Dictionary bad_words_dictionary { get; set; }
    public Lastname lastname { get; set; }
    public Firstname firstname { get; set; }
    public Email email { get; set; }
    public Phone phone { get; set; }
    public Fullname fullname { get; set; }
    public Guestname guestname { get; set; }
}

public class Bad_Words_Dictionary
{
}

public class Lastname
{
    public string validation_error { get; set; }
    public string rule { get; set; }
}

public class Firstname
{
    public string rule { get; set; }
    public string validation_error { get; set; }
}

public class Email
{
    public string validation_error { get; set; }
    public string rule { get; set; }
}

public class Phone
{
    public string rule { get; set; }
    public string validation_error { get; set; }
}

public class Fullname
{
    public string validation_error { get; set; }
    public string rule { get; set; }
}

public class Guestname
{
    public string rule { get; set; }
    public string validation_error { get; set; }
}

public class Paymentterms1
{
    public Cancellation2 cancellation { get; set; }
}

public class Cancellation2
{
    public string type { get; set; }
    public string description { get; set; }
    public string type_translation { get; set; }
    public int non_refundable_anymore { get; set; }
    public Timeline timeline { get; set; }
}

public class Timeline
{
    public int nr_stages { get; set; }
    public Stage[] stages { get; set; }
    public string u_currency_code { get; set; }
    public string currency_code { get; set; }
    public string policygroup_instance_id { get; set; }
}

public class Stage
{
    public string date_until { get; set; }
    public int after_checkin { get; set; }
    public string amount_pretty { get; set; }
    public string text { get; set; }
    public float amount { get; set; }
    public string stage_translation { get; set; }
    public int is_free { get; set; }
}

public class Product_Price_Breakdown1
{
    public Item6[] items { get; set; }
    public Price_Display_Config3[] price_display_config { get; set; }
    public Net_Amount3 net_amount { get; set; }
    public int has_long_stays_weekly_rate_price { get; set; }
    public Included_Taxes_And_Charges_Amount3 included_taxes_and_charges_amount { get; set; }
    public Excluded_Amount3 excluded_amount { get; set; }
    public Gross_Amount_Hotel_Currency3 gross_amount_hotel_currency { get; set; }
    public Gross_Amount3 gross_amount { get; set; }
    public int has_long_stays_monthly_rate_price { get; set; }
    public All_Inclusive_Amount3 all_inclusive_amount { get; set; }
    public Charges_Details3 charges_details { get; set; }
    public Gross_Amount_Per_Night3 gross_amount_per_night { get; set; }
    public All_Inclusive_Amount_Hotel_Currency3 all_inclusive_amount_hotel_currency { get; set; }
    public object[] benefits { get; set; }
    public int nr_stays { get; set; }
}

public class Net_Amount3
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Included_Taxes_And_Charges_Amount3
{
    public string amount_rounded { get; set; }
    public string currency { get; set; }
    public int value { get; set; }
    public string amount_unrounded { get; set; }
}

public class Excluded_Amount3
{
    public string currency { get; set; }
    public string amount_rounded { get; set; }
    public string amount_unrounded { get; set; }
    public float value { get; set; }
}

public class Gross_Amount_Hotel_Currency3
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class Gross_Amount3
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class All_Inclusive_Amount3
{
    public string amount_rounded { get; set; }
    public string currency { get; set; }
    public float value { get; set; }
    public string amount_unrounded { get; set; }
}

public class Charges_Details3
{
    public string translated_copy { get; set; }
    public string mode { get; set; }
    public Amount3 amount { get; set; }
}

public class Amount3
{
    public int value { get; set; }
    public string currency { get; set; }
}

public class Gross_Amount_Per_Night3
{
    public string amount_unrounded { get; set; }
    public float value { get; set; }
    public string currency { get; set; }
    public string amount_rounded { get; set; }
}

public class All_Inclusive_Amount_Hotel_Currency3
{
    public float value { get; set; }
    public string amount_unrounded { get; set; }
    public string amount_rounded { get; set; }
    public string currency { get; set; }
}

public class Item6
{
    public Base3 _base { get; set; }
    public string name { get; set; }
    public string inclusion_type { get; set; }
    public object details { get; set; }
    public string kind { get; set; }
    public Item_Amount3 item_amount { get; set; }
}

public class Base3
{
    public string kind { get; set; }
    public float base_amount { get; set; }
}

public class Item_Amount3
{
    public string currency { get; set; }
    public string amount_rounded { get; set; }
    public string amount_unrounded { get; set; }
    public float value { get; set; }
}

public class Price_Display_Config3
{
    public int value { get; set; }
    public string key { get; set; }
}

public class Min_Price
{
    public Extra_Charges_Breakdown extra_charges_breakdown { get; set; }
    public string currency { get; set; }
    public int has_incalculable_charges { get; set; }
    public string ratechannel { get; set; }
    public float price { get; set; }
}

public class Extra_Charges_Breakdown
{
    public Extra_Charge[] extra_charge { get; set; }
    public float net_price { get; set; }
    public string currency { get; set; }
}

public class Extra_Charge
{
    public object charge_amount { get; set; }
    public int charge_price_mode { get; set; }
    public object amount { get; set; }
    public string currency { get; set; }
    public string type { get; set; }
    public int excluded { get; set; }
    public string name { get; set; }
}

public class Bed_Configurations1
{
    public Bed_Types1[] bed_types { get; set; }
}

public class Bed_Types1
{
    public int count { get; set; }
    public int bed_type { get; set; }
    public string name_with_count { get; set; }
}

public class Photo1
{
    public string url_max1280 { get; set; }
    public string url_max1024 { get; set; }
    public string url_square180 { get; set; }
    public string url_max550 { get; set; }
    public string url_square60 { get; set; }
}

public class Highlight1
{
    public int id { get; set; }
    public string translated_name { get; set; }
    public string icon { get; set; }
}

public class Facility2
{
    public int id { get; set; }
    public string name { get; set; }
}

public class Top_Ufi_Benefits
{
    public string icon { get; set; }
    public string translated_name { get; set; }
}

public class Room_Recommendation
{
    public int babies { get; set; }
    public int children { get; set; }
    public int adults { get; set; }
    public string block_id { get; set; }
    public int total_extra_bed_price_in_hotel_currency { get; set; }
    public int total_extra_bed_price { get; set; }
    public int number_of_extra_beds { get; set; }
}
