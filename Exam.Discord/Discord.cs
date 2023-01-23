using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.Discord
{
    public class Discord : IDiscord
    {
        private Dictionary<string, Message> messagesById = new Dictionary<string, Message>();
        private Dictionary<string, Message> messagesByChannel = new Dictionary<string, Message>();

        public int Count => messagesById.Keys.Count;

        public bool Contains(Message message)
            => messagesById.ContainsKey(message.Id);

        public void DeleteMessage(string messageId)
        {
            if (!messagesById.ContainsKey(messageId))
            {
                throw new ArgumentException();
            }

            messagesById.Remove(messageId);
            messagesByChannel.Remove(messagesById[messageId].Channel);
        }

        public IEnumerable<Message> GetAllMessagesOrderedByCountOfReactionsThenByTimestampThenByLengthOfContent()
            => messagesById.Values.OrderByDescending(m => m.Reactions)
                                  .ThenBy(m => m.Timestamp)
                                  .ThenBy(m => m.Content.Length);

        public IEnumerable<Message> GetChannelMessages(string channel)
            => (IEnumerable<Message>)messagesByChannel[channel];

        public Message GetMessage(string messageId)
        {
            if (!messagesById.ContainsKey(messageId))
            {
                throw new ArgumentException();
            }

            return messagesById[messageId];
        }

        public IEnumerable<Message> GetMessageInTimeRange(int lowerBound, int upperBound)
            => messagesById.Values
            .Where(m => m.Timestamp >= lowerBound && m.Timestamp <= upperBound)
            .OrderByDescending(m => messagesByChannel.Values.Count);

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
            if (!messagesById.ContainsKey(messageId))
            {
                throw new ArgumentException();
            }

            messagesById[messageId].Reactions.Add(reaction);
        }

        public void SendMessage(Message message)
        {
            messagesById.Add(message.Id, message);
            messagesByChannel.Add(message.Channel, message);
        }
    }
}
