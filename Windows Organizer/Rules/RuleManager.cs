using System;
using System.Collections.Generic;

namespace Windows_Organizer
{
    class RuleManager
    {
        private static List<Rule> rules;

        public RuleManager() => rules = FileManager.LoadSettings();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rule"></param>
        /// <returns></returns>
        public bool AddRule(Rule rule)
        {
            if (rule != null) 
            {
                if (!RuleExists(rule))
                {
                    rules.Add(rule);
                    FileManager.SaveSettings(rules);

                    return true;
                }
            }

            return false;
        }

        public bool RemoveRuleByIndex(int index)
        {
            try
            {
                rules.RemoveAt(index);
                FileManager.SaveSettings(rules);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void EditRule(int index, Rule rule) => rules[index] = rule;

        public bool RemoveRule(Rule rule)
        {
            foreach (Rule r in rules)
            {
                if (rule.CompareTo(r) == 1)
                {
                    rules.Remove(r);
                    FileManager.SaveSettings(rules);

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rule"></param>
        /// <returns></returns>
        private bool RuleExists(Rule rule)
        {
            foreach (Rule r in rules)
            {
                if (rule.CompareTo(r) == 1)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Rule> GetRules() => rules;

    }
}
