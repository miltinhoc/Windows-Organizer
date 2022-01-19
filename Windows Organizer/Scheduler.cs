using System.IO;
using Newtonsoft.Json;

namespace Windows_Organizer
{
    class Scheduler
    {
        private static readonly string FILENAME = "scheduler.json";
        private SchedulerConfigs schedulerConfigs;

        public Scheduler()
        {
            schedulerConfigs = new SchedulerConfigs();
        }

        public void Save()
        {
            if (schedulerConfigs != null)
            {
                File.WriteAllText(FILENAME, JsonConvert.SerializeObject(schedulerConfigs));
            }
        }

        public void Load()
        {
            if (File.Exists(FILENAME))
            {
                string content = File.ReadAllText(FILENAME);
                schedulerConfigs = JsonConvert.DeserializeObject<SchedulerConfigs>(content);
            }
        }

        public void SetInterval(int interval)
        {
            if (schedulerConfigs != null)
            {
                schedulerConfigs.Interval = interval;
            }
        }

        public int GetInterval()
        {
            if (schedulerConfigs != null)
            {
                return schedulerConfigs.Interval;
            }

            return -1;
        }

        public void ChangeState(SchedulerState schedulerState) => schedulerConfigs.SchedulerState = schedulerState;

        public SchedulerState GetState() => schedulerConfigs.SchedulerState;
    }

    public enum SchedulerState
    {
        OFF,
        ON
    }

}