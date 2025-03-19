from flask import Flask, jsonify
from flask_cors import CORS
import fastf1

app = Flask(__name__)
CORS(app)  # Enable cross-origin requests

fastf1.Cache.enable_cache('cache')  # Enable local caching

@app.route('/events', methods=['GET'])
def get_event_schedule():
    # Get current season schedule
    schedule = fastf1.get_event_schedule(2024)
    events = []
    for _, row in schedule.iterrows():
        events.append({
            "round": row["RoundNumber"],
            "name": row["EventName"],
            "location": row["Location"],
            "country": row["Country"],
            "date": row["Session1Date"].strftime("%Y-%m-%d"),
            "time": row["Session1Time"].strftime("%H:%M")
        })
    return jsonify(events)

@app.route('/results/<int:year>/<int:round_number>', methods=['GET'])
def get_race_results(year, round_number):
    event = fastf1.get_event(year, round_number)
    results = event.get_race_results()
    driver_results = []
    for _, row in results.iterrows():
        driver_results.append({
            "driver": row["Abbreviation"],
            "team": row["TeamName"],
            "grid": row["GridPosition"],
            "position": row["Position"],
            "points": row["Points"],
            "status": row["Status"]
        })
    return jsonify(driver_results)

@app.route('/timing-data/<int:year>/<int:round_number>', methods=['GET'])
def get_timing_data(year, round_number):
    session = fastf1.get_session(year, round_number, "R")
    session.load()
    laps = session.laps
    lap_data = []
    for _, lap in laps.iterrows():
        lap_data.append({
            "driver": lap["Driver"],
            "lap_number": lap["LapNumber"],
            "sector_1": lap["Sector1Time"],
            "sector_2": lap["Sector2Time"],
            "sector_3": lap["Sector3Time"],
            "pit_stop": lap["PitInTime"]
        })
    return jsonify(lap_data)

@app.route('/track-status/<int:year>/<int:round_number>', methods=['GET'])
def get_track_status(year, round_number):
    session = fastf1.get_session(year, round_number, "R")
    session.load()
    status = session.track_status
    track_status = []
    for _, row in status.iterrows():
        track_status.append({
            "time": row["Time"].strftime("%H:%M:%S"),
            "status": row["Status"]
        })
    return jsonify(track_status)

@app.route('/session-status/<int:year>/<int:round_number>', methods=['GET'])
def get_session_status(year, round_number):
    session = fastf1.get_session(year, round_number, "R")
    session.load()
    return jsonify({"status": session.status})

@app.route('/race-control/<int:year>/<int:round_number>', methods=['GET'])
def get_race_control_messages(year, round_number):
    session = fastf1.get_session(year, round_number, "R")
    session.load()
    messages = session.race_control_messages
    race_control = []
    for _, row in messages.iterrows():
        race_control.append({
            "message": row["Message"],
            "category": row["Category"],
            "time": row["Time"].strftime("%H:%M:%S")
        })
    return jsonify(race_control)

@app.route('/telemetry/<int:year>/<int:round_number>/<string:driver>', methods=['GET'])
def get_telemetry(year, round_number, driver):
    session = fastf1.get_session(year, round_number, "R")
    session.load()
    drv = session.get_driver(driver)
    telemetry = drv.get_car_data()
    telemetry_data = []
    for _, row in telemetry.iterrows():
        telemetry_data.append({
            "time": row["Time"].strftime("%H:%M:%S"),
            "speed": row["Speed"],
            "rpm": row["RPM"],
            "gear": row["nGear"]
        })
    return jsonify(telemetry_data)

if __name__ == '__main__':
    app.run(debug=True, port=5000)
