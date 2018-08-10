namespace qbittorrentremote
{
    public class WebUITorrent
    {
        public string Added_on { get; set; }
        public string Amount_left { get; set; }
        public string Auto_tmm { get; set; }
        public string Category { get; set; }
        public string Completed { get; set; }
        public string Completion_on { get; set; }
        public string Dl_limit { get; set; }
        public string Dlspeed { get; set; }
        public string Downloaded { get; set; }
        public string Downloaded_session { get; set; }
        public string Eta { get; set; }
        public string F_l_piece_prio { get; set; }
        public string Force_start { get; set; }
        public string Hash { get; set; }
        public string Last_activity { get; set; }
        public string Magnet_uri { get; set; }
        public string Max_ratio { get; set; }
        public string Max_seeding_time { get; set; }
        public string Name { get; set; }
        public string Num_complete { get; set; }
        public string Num_incomplete { get; set; }
        public string Num_leechs { get; set; }
        public string Num_seeds { get; set; }
        public string Priority { get; set; }
        public string Progress { get; set; }
        public string Ratio { get; set; }
        public string Ratio_limit { get; set; }
        public string Save_path { get; set; }
        public string Seeding_time_limit { get; set; }
        public string Seen_complete { get; set; }
        public string Seq_dl { get; set; }
        public string Size { get; set; }
        public string State { get; set; }
        public string Super_seeding { get; set; }
        public string Tags { get; set; }
        public string Time_active { get; set; }
        public string Total_size { get; set; }
        public string Tracker { get; set; }
        public string Up_limit { get; set; }
        public string Uploaded { get; set; }
        public string Uploaded_session { get; set; }
        public string Upspeed { get; set; }

        public WebUITorrent(string added_on,
                            string amount_left,
                            string auto_tmm,
                            string category,
                            string completed,
                            string completion_on,
                            string dl_limit,
                            string dlspeed,
                            string downloaded,
                            string downloaded_session,
                            string eta,
                            string f_l_piece_prio,
                            string force_start,
                            string hash,
                            string last_activity,
                            string magnet_uri,
                            string max_ratio,
                            string max_seeding_time,
                            string name,
                            string num_complete,
                            string num_incomplete,
                            string num_leechs,
                            string num_seeds,
                            string priority,
                            string progress,
                            string ratio,
                            string ratio_limit,
                            string save_path,
                            string seeding_time_limit,
                            string seen_complete,
                            string seq_dl,
                            string size,
                            string state,
                            string super_seeding,
                            string tags,
                            string time_active,
                            string total_size,
                            string tracker,
                            string up_limit,
                            string uploaded,
                            string uploaded_session,
                            string upspeed)
        {
            Added_on = added_on;
            Amount_left = amount_left;
            Auto_tmm = auto_tmm;
            Category = category;
            Completed = completed;
            Completion_on = completion_on;
            Dl_limit = dl_limit;
            Dlspeed = dlspeed;
            Downloaded = downloaded;
            Downloaded_session = downloaded_session;
            Eta = eta;
            F_l_piece_prio = f_l_piece_prio;
            Force_start = force_start;
            Hash = hash;
            Last_activity = last_activity;
            Magnet_uri = magnet_uri;
            Max_ratio = max_ratio;
            Max_seeding_time = max_seeding_time;
            Name = name;
            Num_complete = num_complete;
            Num_incomplete = num_incomplete;
            Num_leechs = num_leechs;
            Num_seeds = num_seeds;
            Priority = priority;
            Progress = progress;
            Ratio = ratio;
            Ratio_limit = ratio_limit;
            Save_path = save_path;
            Seeding_time_limit = seeding_time_limit;
            Seen_complete = seen_complete;
            Seq_dl = seq_dl;
            Size = size;
            State = state;
            Super_seeding = super_seeding;
            Tags = tags;
            Time_active = time_active;
            Total_size = total_size;
            Tracker = tracker;
            Up_limit = up_limit;
            Uploaded = uploaded;
            Uploaded_session = uploaded_session;
            Upspeed = upspeed;
        }
    }
}
