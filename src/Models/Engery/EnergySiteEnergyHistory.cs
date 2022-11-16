namespace TeslaAPI.Models.Engery
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class EnergySiteEnergyHistory
    {
        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets the period of time the TimeSeries spans over.
        /// "day", "week", "month", "year".
        /// </summary>
        [JsonProperty("period")]
        public string Period { get; set; }

        /// <summary>
        /// Gets or sets entries for the period.
        /// For example, if the period value is week, there are 7 entries, each one representing the energy generated for one day.
        /// </summary>
        [JsonProperty("time_series")]
        public List<EnergySiteEnergyHistoryTime> TimeSeries { get; set; } = new List<EnergySiteEnergyHistoryTime>();
    }

    public class EnergySiteEnergyHistoryTime
    {
        [JsonProperty("timestamp")]
        public DateTime Timesatmp { get; set; }

        /// <summary>
        /// Gets or sets energy generated by the solar panels, in kWh.
        /// </summary>
        [JsonProperty("solar_energy_exported")]
        public int SolarEnergyExported { get; set; }

        [JsonProperty("generator_energy_exported")]
        public int GeneratorEnergyExported { get; set; }

        [JsonProperty("grid_energy_imported")]
        public int GridEnergyImported { get; set; }

        [JsonProperty("grid_services_energy_imported")]
        public int GridServicesEnergyImported { get; set; }

        [JsonProperty("grid_services_energy_exported")]
        public int GridServicesEnergyExported { get; set; }

        [JsonProperty("grid_energy_exported_from_solar")]
        public int GridEnergyExportedFromSolar { get; set; }

        [JsonProperty("grid_energy_exported_from_generator")]
        public int GridEnergyExportedFromGenerator { get; set; }

        [JsonProperty("grid_energy_exported_from_battery")]
        public int GridEnergyExportedFromBattery { get; set; }

        [JsonProperty("battery_energy_exported")]
        public int BatteryEnergyExported { get; set; }

        [JsonProperty("battery_energy_imported_from_grid")]
        public int BatteryEnergyImportedFromGrid { get; set; }

        [JsonProperty("battery_energy_imported_from_solar")]
        public int BatteryEnergyImportedFromSolar { get; set; }

        [JsonProperty("battery_energy_imported_from_generator")]
        public int BatteryEnergyImportedFromGenerator { get; set; }

        [JsonProperty("consumer_energy_imported_from_grid")]
        public int ConsumerEnergyImportedFromGrid { get; set; }

        [JsonProperty("consumer_energy_imported_from_solar")]
        public int ConsumerEnergyImportedFromSolar { get; set; }

        [JsonProperty("consumer_energy_imported_from_battery")]
        public int ConsumerEnergyImportedFromBattery { get; set; }

        [JsonProperty("consumer_energy_imported_from_generator")]
        public int ConsumerEnergyImportedFromGenerator { get; set; }
    }
}
}
