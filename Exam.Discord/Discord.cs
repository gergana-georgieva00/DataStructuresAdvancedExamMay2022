using System;
using System.Collections.Generic;

namespace Exam.Discord
{
    public class Discord : IDiscord
    {
        public int Count => throw new NotImplementedException();

        public bool Contains(Message message)
        {
            throw new NotImplementedException();
        }

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
