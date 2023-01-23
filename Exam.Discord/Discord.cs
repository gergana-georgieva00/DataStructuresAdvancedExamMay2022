using System;
using System.Collections.Generic;

namespace Exam.Discord
{
    public class Discord : IDiscord
    {
        private Dictionary<string, Message> messagesById = new Dictionary<string, Message>();

        public int Count => messagesById.Keys.Count;

        public bool Contains(Message message)
            => messagesById.ContainsKey(message.Id);

        public void DeleteMessage(string messageId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetAllMessagesOrderedByCountOfReactionsThenByTimestampThenByLengthOfContent()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetChannelMessages(string channel)
        {
            throw new NotImplementedException();
        }

        public Message GetMessage(string messageId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetMessageInTimeRange(int lowerBound, int upperBound)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetMessagesByReactions(List<string> reactions)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetTop3MostReactedMessages()
        {
            throw new NotImplementedException();
        }

        public void ReactToMessage(string messageId, string reaction)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
