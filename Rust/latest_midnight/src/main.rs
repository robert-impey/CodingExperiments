use chrono::{Local, TimeZone, Datelike, MappedLocalTime, DateTime};

fn latest_local_midnight() -> MappedLocalTime<DateTime<Local>> {
    let now = Local::now();
    Local.with_ymd_and_hms(now.year(), now.month(), now.day(), 0, 0, 0)
}

fn main() {
    let midnight = latest_local_midnight();
    println!("Latest local midnight: {:?}", midnight.unwrap());
}
