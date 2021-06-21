using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.TextToSpeech.V1;
using System.IO;

namespace TestAPI
{
    class GoogleTest
    {
        private string jsonName = "key.json";

        private string baseDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        private TextToSpeechClient client;

        public GoogleTest() {
            Console.WriteLine("Init Google Test");
            AuthExplicit();
        }

        private void AuthExplicit() {
            string jsonPath = $"{baseDir}/{jsonName}";

            Console.WriteLine("Init Auth");
            TextToSpeechClientBuilder builder = new TextToSpeechClientBuilder
            {
                CredentialsPath = jsonPath
            };

            client = builder.Build();
        }

        public void ListVoices(string code = "En") {
            
            var responseList = client.ListVoices(code);
            foreach (var voice in responseList.Voices)
            {
                Console.WriteLine($"{voice.Name} ({voice.SsmlGender}); Language codes: {string.Join(", ", voice.LanguageCodes)}");
            }
        }

        public void GenerateAudio(string textInput, string outputFile = "output.mp3") {
            var input = new SynthesisInput
            {
                //Text = textInput
                Ssml = textInput
            };

            // Std : M:ABDIJ; F:CEFGH
            // WN : M:ABDIJ; F:CEFGH
            // Build the voice request.
            var voiceSelection = new VoiceSelectionParams
            {
                LanguageCode = "en-US",
                Name = "en-US-Wavenet-F",
                //Name = "en-US-Standard-C",
                SsmlGender = SsmlVoiceGender.Female
            };

            // Specify the type of audio file.
            var audioConfig = new AudioConfig
            {
                AudioEncoding = AudioEncoding.Mp3
            };

            // Perform the text-to-speech request.
            var response = client.SynthesizeSpeech(input, voiceSelection, audioConfig);

            // Write the response to the output file.
            //string outputFile = "output-voting.mp3";
            
            string outputPath = $"{baseDir}/output/{outputFile}";
            using (var output = File.Create(outputPath))
            {
                response.AudioContent.WriteTo(output);
            }
            Console.WriteLine($"Audio content written to file \"{outputFile}\"");
        }
    }
}