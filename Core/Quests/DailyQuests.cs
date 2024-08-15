using Newtonsoft.Json;

namespace Server
{
    public class DailyQuests
    {
        public List<Type> Quests { get; set; }
        public List<Quest> QuestsProgress { get; set; } = new List<Quest>();
        public static Dictionary<int, DailyQuests> QuestList { get; set; } = new Dictionary<int, DailyQuests>();

        public DailyQuests(List<Type> quests)
        {
            Quests = quests;
        }

        public static void AddQuest(int index, DailyQuests quest)
        {
            QuestList[index] = quest;
        }

        public static DailyQuests GetQuests(int index, dynamic metadata)
        {
            if (QuestList.TryGetValue(index, out var dailyQuests))
            {
                dailyQuests.ParseMetadata(metadata);
                return dailyQuests;
            }

            return null;
        }

        public void ParseMetadata(dynamic metadata)
        {
            QuestsProgress = new List<Quest>();
            var metadataParsed = new Dictionary<string, dynamic>();

            if (metadata != null)
            {
                foreach (var key in metadata)
                {
                    if (metadata[key]?.Namespace != null)
                    {
                        metadataParsed[metadata[key].Namespace.ToString()] = metadata[key];
                    }
                }
            }

            foreach (var questType in Quests)
            {
                var quest = (Quest)Activator.CreateInstance(questType);
                quest.ParseMetadata(metadataParsed);
                QuestsProgress.Add(quest);
            }
        }

        public dynamic GenerateMetadata(bool appendPublicData = false, bool exportString = false)
        {
            var metadata = new List<dynamic>();

            foreach (var quest in QuestsProgress)
            {
                metadata.Add(quest.GetMetadata(appendPublicData));
            }

            return exportString ? JsonConvert.SerializeObject(metadata) : metadata;
        }
    }
}
