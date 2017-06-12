﻿namespace ChannelSurfCli.Models
{
    public class Combined
    {
        public class ChannelsMapping : MsTeams.Channel
        {
            public string slackChannelId { get; set; }
            public string slackChannelName { get; set; }
            public string teamsFolderId { get; set; }
        }

        public class AttachmentsMapping : Slack.Attachments
        {
            public string msChannelName { get; set; }
            public string msChannelId { get; set; }
        }
    }
}
