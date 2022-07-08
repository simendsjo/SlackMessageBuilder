﻿using System.Text.Json.Serialization;

namespace SlackMessageBuilder
{
    /// <summary>
    /// A plain-text input, similar to the HTML &lt;input&gt; tag, creates a field where a user can enter freeform data. It can appear as a single-line field or a larger text area using the multiline flag.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/block-elements#input">https://api.slack.com/reference/block-kit/block-elements#input</a>
    /// </summary>
    public class PlainTextInput : TypedObject, IInputElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlainTextInput"/> class.
        /// </summary>
        /// <param name="actionId">An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.</param>
        /// <param name="placeholder">A <see cref="PlainText"/> object that defines the placeholder text shown in the plain-text input. Maximum length for the text in this field is 150 characters.</param>
        /// <param name="initialValue">The initial value in the plain-text input when it is loaded.</param>
        /// <param name="multiline">Indicates whether the input will be a single line (false) or a larger textarea (true). Defaults to false.</param>
        /// <param name="minLength">The minimum length of input that the user must provide. If the user provides less, they will receive an error. Maximum value is 3000.</param>
        /// <param name="maxLength">The maximum length of input that the user can provide. If the user provides more, they will receive an error.</param>
        /// <param name="dispatchActionConfig">A dispatch configuration object that determines when during text input the element returns a block_actions payload.</param>
        /// <param name="focusOnLoad">Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.</param>
        public PlainTextInput(
            string actionId,
            PlainText? placeholder = null,
            string? initialValue = null,
            bool? multiline = null,
            int? minLength = null,
            int? maxLength = null,
            DispatchActionConfig? dispatchActionConfig = null,
            bool? focusOnLoad = null) : base("plain_text_input")
        {
            ActionId = actionId;
            Placeholder = placeholder;
            InitialValue = initialValue;
            Multiline = multiline;
            MinLength = minLength;
            MaxLength = maxLength;
            DispatchActionConfig = dispatchActionConfig;
            FocusOnLoad = focusOnLoad;
        }

        /// <summary>
        /// An identifier for the action triggered when a menu option is selected. You can use this when you receive an interaction payload to <a href="https://api.slack.com/interactivity/handling#payloads">identify the source of the action</a>. Should be unique among all other action_ids in the containing block. Maximum length for this field is 255 characters.
        /// </summary>
        [JsonPropertyName("action_id")]
        public string ActionId { get; }

        /// <summary>
        /// A <see cref="PlainText"/> object that defines the placeholder text shown in the plain-text input. Maximum length for the text in this field is 150 characters.
        /// </summary>
        [JsonPropertyName("placeholder")]
        public PlainText? Placeholder { get; }

        /// <summary>
        /// The initial value in the plain-text input when it is loaded.
        /// </summary>
        [JsonPropertyName("initial_value")]
        public string? InitialValue { get; }

        /// <summary>
        /// Indicates whether the input will be a single line (false) or a larger textarea (true). Defaults to false.
        /// </summary>
        [JsonPropertyName("multiline")]
        public bool? Multiline { get; }

        /// <summary>
        /// The minimum length of input that the user must provide. If the user provides less, they will receive an error. Maximum value is 3000.
        /// </summary>
        [JsonPropertyName("min_length")]
        public int? MinLength { get; }

        /// <summary>
        /// The maximum length of input that the user can provide. If the user provides more, they will receive an error.
        /// </summary>
        [JsonPropertyName("max_length")]
        public int? MaxLength { get; }

        /// <summary>
        /// A dispatch configuration object that determines when during text input the element returns a block_actions payload.
        /// </summary>
        [JsonPropertyName("dispatch_action_config")]
        public DispatchActionConfig? DispatchActionConfig { get; }

        /// <summary>
        /// Indicates whether the element will be set to auto focus within the view object. Only one element can be set to true. Defaults to false.
        /// </summary>
        [JsonPropertyName("focus_on_load")]
        public bool? FocusOnLoad { get; }
    }
}