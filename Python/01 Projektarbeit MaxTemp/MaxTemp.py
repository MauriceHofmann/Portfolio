import pandas as pd
import sys

# Variablen
dateiname = "temps.csv"

# Einlesen der CSV-Datei in DataFrame
temp_dataframe = pd.read_csv(dateiname)

# Bearbeiten der CSV-Datei durch anfügen eines Headers
temp_dataframe.columns = ["Sensor", "Datum und Uhrzeit", "Temperatur"]

# Ermitteln des maximalen, minimalen und duchschnittlichen Temperaturwertes
max_temp = temp_dataframe["Temperatur"].max()
min_temp = temp_dataframe["Temperatur"].min()
avg_temp = temp_dataframe["Temperatur"].mean()

# Ausgabe der ermittelten Temperaturwerte
print(f"Der maximale Temperaturwert liegt bei: {max_temp}°C")
print(f"Der minimale Temperaturwert liegt bei: {min_temp}°C")
print(f"Der durchschnittliche Temperaturwert liegt bei: {round(avg_temp, 1)}°C")