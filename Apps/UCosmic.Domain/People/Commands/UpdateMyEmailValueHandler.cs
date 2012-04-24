﻿using System;

namespace UCosmic.Domain.People
{
    public class UpdateMyEmailValueHandler : IHandleCommands<UpdateMyEmailValueCommand>
    {
        private readonly IProcessQueries _queryProcessor;
        private readonly ICommandEntities _entities;

        public UpdateMyEmailValueHandler(IProcessQueries queryProcessor, ICommandEntities entities)
        {
            _queryProcessor = queryProcessor;
            _entities = entities;
        }

        public void Handle(UpdateMyEmailValueCommand command)
        {
            if (command == null) throw new ArgumentNullException("command");

            command.ChangedState = false;

            // get the email address
            var email = _queryProcessor.Execute(
                new GetMyEmailAddressByNumberQuery
                {
                    Principal = command.Principal,
                    Number = command.Number,
                }
            );

            // only process matching email
            if (email == null) return;

            // only update the value if it was respelled
            if (email.Value == command.NewValue) return;

            email.Value = command.NewValue;
            _entities.Update(email);
            command.ChangedState = true;
        }
    }
}