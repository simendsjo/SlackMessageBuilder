﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    /// A radio button group that allows a user to choose one item from a list of possible options.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#radio">https://api.slack.com/reference/block-kit/block-elements#radio</a>
    /// </summary>
    public class RadioButtons : TypedObject, ISectionElement, IInputElement, IActionsElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButtons"/> class.
        /// </summary>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="options">An array of <see cref="Option"/> objects. A maximum of 10 options are allowed.</param>
        /// <param name="initialOption">An <see cref="Option"/> object that exactly matches one of the options within options. This option will be selected when the radio button group initially loads.</param>
        /// <param name="confirmDialog">A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the radio buttons in this element.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public RadioButtons(
            string actionId,
            IEnumerable<Option> options,
            Option? initialOption = null,
            Confirm? confirmDialog = null,
            bool? focusOnLoad = null) : base("radio_buttons")
        {
            ActionId = actionId;
            Options = options;
            InitialOption = initialOption;
            ConfirmDialog = confirmDialog;
            FocusOnLoad = focusOnLoad;
        }

        /// <summary>
        /// An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.
        /// </summary>
        [JsonPropertyName("action_id")]
        public string ActionId { get; }

        /// <summary>
        /// An array of <see cref="Option"/> objects. A maximum of 10 options are allowed.
        /// </summary>
        [JsonPropertyName("options")]
        public IEnumerable<Option> Options { get; }

        /// <summary>
        /// An <see cref="Option"/> object that exactly matches one of the options within options. This option will be selected when the radio button group initially loads.
        /// </summary>
        [JsonPropertyName("initial_optoin")]
        public Option? InitialOption { get; }

        /// <summary>
        /// A <see cref="Confirm"/> object that defines an optional confirmation dialog that appears after clicking one of the radio buttons in this element.
        /// </summary>
        [JsonPropertyName("confirm")]
        public Confirm? ConfirmDialog { get; }

        /// <summary>
        /// Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.
        /// </summary>
        [JsonPropertyName("focus_on_load")]
        public bool? FocusOnLoad { get; }
    }
}