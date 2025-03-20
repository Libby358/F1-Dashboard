import fastf1
from flask import Flask, jsonify
import pandas as pd

app = Flask(__name__)

@app.route('/events', methods=['GET'])
def get_event_schedule():
    # Assuming 'schedule' is your pandas DataFrame containing the event schedule
    event_data = []
    
    # Iterate over rows in the schedule DataFrame
    for index, row in schedule.iterrows():
        event = {
            "RoundNumber": row['RoundNumber'],
            "Country": row['Country'],
            "Location": row['Location'],
            "OfficialEventName": row['OfficialEventName'],
            "EventDate": row['EventDate'].strftime('%Y-%m-%d %H:%M:%S') if pd.notna(row['EventDate']) else None,
            "EventName": row['EventName'],
            "EventFormat": row['EventFormat'],
            "Session1": row['Session1'],
            "Session1Date": row['Session1Date'].strftime('%Y-%m-%d %H:%M:%S') if pd.notna(row['Session1Date']) else None,
            "Session2": row['Session2'],
            "Session2Date": row['Session2Date'].strftime('%Y-%m-%d %H:%M:%S') if pd.notna(row['Session2Date']) else None,
            "Session3": row['Session3'],
            "Session3Date": row['Session3Date'].strftime('%Y-%m-%d %H:%M:%S') if pd.notna(row['Session3Date']) else None,
            "Session4": row['Session4'],
            "Session4Date": row['Session4Date'].strftime('%Y-%m-%d %H:%M:%S') if pd.notna(row['Session4Date']) else None,
            "Session5": row['Session5'],
            "Session5Date": row['Session5Date'].strftime('%Y-%m-%d %H:%M:%S') if pd.notna(row['Session5Date']) else None
        }
        
        event_data.append(event)
    
    return jsonify(event_data)
