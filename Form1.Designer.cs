
namespace CSHdigitalniSat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labela_vrijeme = new System.Windows.Forms.Label();
            this.labela_datum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxSat = new System.Windows.Forms.CheckBox();
            this.checkBoxDatum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labela_vrijeme
            // 
            this.labela_vrijeme.AutoSize = true;
            this.labela_vrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labela_vrijeme.Location = new System.Drawing.Point(42, 34);
            this.labela_vrijeme.Name = "labela_vrijeme";
            this.labela_vrijeme.Size = new System.Drawing.Size(143, 42);
            this.labela_vrijeme.TabIndex = 0;
            this.labela_vrijeme.Text = "0:00:00";
            // 
            // labela_datum
            // 
            this.labela_datum.AutoSize = true;
            this.labela_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labela_datum.Location = new System.Drawing.Point(43, 104);
            this.labela_datum.Name = "labela_datum";
            this.labela_datum.Size = new System.Drawing.Size(128, 31);
            this.labela_datum.TabIndex = 1;
            this.labela_datum.Text = "8.9.2021.";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "af-ZA - Afrikaans",
            "af-ZA - Afrikaans (South Africa)",
            "am-ET - Amharic",
            "am-ET - Amharic (Ethiopia)",
            "ar-AE - Arabic (U.A.E.)",
            "ar-BH - Arabic (Bahrain)",
            "ar-DZ - Arabic (Algeria)",
            "ar-EG - Arabic (Egypt)",
            "ar-IQ - Arabic (Iraq)",
            "ar-JO - Arabic (Jordan)",
            "ar-KW - Arabic (Kuwait)",
            "ar-LB - Arabic (Lebanon)",
            "ar-LY - Arabic (Libya)",
            "ar-MA - Arabic (Morocco)",
            "arn-CL - Mapudungun",
            "arn-CL - Mapudungun (Chile)",
            "ar-OM - Arabic (Oman)",
            "ar-QA - Arabic (Qatar)",
            "ar-SA - Arabic",
            "ar-SA - Arabic (Saudi Arabia)",
            "ar-SY - Arabic (Syria)",
            "ar-TN - Arabic (Tunisia)",
            "ar-YE - Arabic (Yemen)",
            "as-IN - Assamese",
            "as-IN - Assamese (India)",
            "az-Cyrl-AZ - Azerbaijani (Cyrillic)",
            "az-Cyrl-AZ - Azerbaijani (Cyrillic, Azerbaijan)",
            "az-Latn-AZ - Azerbaijani",
            "az-Latn-AZ - Azerbaijani (Latin)",
            "az-Latn-AZ - Azerbaijani (Latin, Azerbaijan)",
            "ba-RU - Bashkir",
            "ba-RU - Bashkir (Russia)",
            "be-BY - Belarusian",
            "be-BY - Belarusian (Belarus)",
            "bg-BG - Bulgarian",
            "bg-BG - Bulgarian (Bulgaria)",
            "bin-NG - Edo",
            "bin-NG - Edo (Nigeria)",
            "bn-BD - Bangla",
            "bn-BD - Bangla (Bangladesh)",
            "bn-IN - Bangla (India)",
            "bo-CN - Tibetan",
            "bo-CN - Tibetan (PRC)",
            "br-FR - Breton",
            "br-FR - Breton (France)",
            "bs-Cyrl-BA - Bosnian (Cyrillic)",
            "bs-Cyrl-BA - Bosnian (Cyrillic, Bosnia and Herzegovina)",
            "bs-Latn-BA - Bosnian",
            "bs-Latn-BA - Bosnian (Latin)",
            "bs-Latn-BA - Bosnian (Latin, Bosnia and Herzegovina)",
            "ca-ES - Catalan",
            "ca-ES - Catalan (Catalan)",
            "ca-ES-valencia - Valencian (Spain)",
            "chr-Cher-US - Cherokee",
            "chr-Cher-US - Cherokee (Cherokee)",
            "chr-Cher-US - Cherokee (Cherokee)",
            "co-FR - Corsican",
            "co-FR - Corsican (France)",
            "cs-CZ - Czech",
            "cs-CZ - Czech (Czech Republic)",
            "cy-GB - Welsh",
            "cy-GB - Welsh (United Kingdom)",
            "da-DK - Danish",
            "da-DK - Danish (Denmark)",
            "de-AT - German (Austria)",
            "de-CH - German (Switzerland)",
            "de-DE - German",
            "de-DE - German (Germany)",
            "de-LI - German (Liechtenstein)",
            "de-LU - German (Luxembourg)",
            "dsb-DE - Lower Sorbian",
            "dsb-DE - Lower Sorbian (Germany)",
            "dv-MV - Divehi",
            "dv-MV - Divehi (Maldives)",
            "dz-BT - Dzongkha (Bhutan)",
            "el-GR - Greek",
            "el-GR - Greek (Greece)",
            "en-029 - English (Caribbean)",
            "en-AE - English (United Arab Emirates)",
            "en-AU - English (Australia)",
            "en-BZ - English (Belize)",
            "en-CA - English (Canada)",
            "en-GB - English (United Kingdom)",
            "en-HK - English (Hong Kong SAR)",
            "en-ID - English (Indonesia)",
            "en-IE - English (Ireland)",
            "en-IN - English (India)",
            "en-JM - English (Jamaica)",
            "en-MY - English (Malaysia)",
            "en-NZ - English (New Zealand)",
            "en-PH - English (Republic of the Philippines)",
            "en-SG - English (Singapore)",
            "en-TT - English (Trinidad and Tobago)",
            "en-US - English",
            "en-US - English (United States)",
            "en-ZA - English (South Africa)",
            "en-ZW - English (Zimbabwe)",
            "es-419 - Spanish (Latin America)",
            "es-AR - Spanish (Argentina)",
            "es-BO - Spanish (Bolivia)",
            "es-CL - Spanish (Chile)",
            "es-CO - Spanish (Colombia)",
            "es-CR - Spanish (Costa Rica)",
            "es-CU - Spanish (Cuba)",
            "es-DO - Spanish (Dominican Republic)",
            "es-EC - Spanish (Ecuador)",
            "es-ES - Spanish",
            "es-ES - Spanish (Spain)",
            "es-GT - Spanish (Guatemala)",
            "es-HN - Spanish (Honduras)",
            "es-MX - Spanish (Mexico)",
            "es-NI - Spanish (Nicaragua)",
            "es-PA - Spanish (Panama)",
            "es-PE - Spanish (Peru)",
            "es-PR - Spanish (Puerto Rico)",
            "es-PY - Spanish (Paraguay)",
            "es-SV - Spanish (El Salvador)",
            "es-US - Spanish (United States)",
            "es-UY - Spanish (Uruguay)",
            "es-VE - Spanish (Bolivarian Republic of Venezuela)",
            "et-EE - Estonian",
            "et-EE - Estonian (Estonia)",
            "eu-ES - Basque",
            "eu-ES - Basque (Basque)",
            "fa-IR - Persian",
            "fa-IR - Persian (Iran)",
            "ff-Latn-NG - Fulah (Latin, Nigeria)",
            "ff-Latn-SN - Fulah",
            "ff-Latn-SN - Fulah (Latin)",
            "ff-Latn-SN - Fulah (Latin, Senegal)",
            "fi-FI - Finnish",
            "fi-FI - Finnish (Finland)",
            "fil-PH - Filipino",
            "fil-PH - Filipino (Philippines)",
            "fo-FO - Faroese",
            "fo-FO - Faroese (Faroe Islands)",
            "fr-029 - French (Caribbean)",
            "fr-BE - French (Belgium)",
            "fr-CA - French (Canada)",
            "fr-CD - French (Congo DRC)",
            "fr-CH - French (Switzerland)",
            "fr-CI - French (Côte d\'Ivoire)",
            "fr-CM - French (Cameroon)",
            "fr-FR - French",
            "fr-FR - French (France)",
            "fr-HT - French (Haiti)",
            "fr-LU - French (Luxembourg)",
            "fr-MA - French (Morocco)",
            "fr-MC - French (Monaco)",
            "fr-ML - French (Mali)",
            "fr-RE - French (Reunion)",
            "fr-SN - French (Senegal)",
            "fy-NL - Frisian",
            "fy-NL - Frisian (Netherlands)",
            "ga-IE - Irish",
            "ga-IE - Irish (Ireland)",
            "gd-GB - Scottish Gaelic",
            "gd-GB - Scottish Gaelic (United Kingdom)",
            "gl-ES - Galician",
            "gl-ES - Galician (Galician)",
            "gn-PY - Guarani",
            "gn-PY - Guarani (Paraguay)",
            "gsw-CH - Alsatian",
            "gsw-FR - Alsatian (France)",
            "gu-IN - Gujarati",
            "gu-IN - Gujarati (India)",
            "ha-Latn-NG - Hausa",
            "ha-Latn-NG - Hausa (Latin)",
            "ha-Latn-NG - Hausa (Latin, Nigeria)",
            "haw-US - Hawaiian",
            "haw-US - Hawaiian (United States)",
            "he-IL - Hebrew",
            "he-IL - Hebrew (Israel)",
            "hi-IN - Hindi",
            "hi-IN - Hindi (India)",
            "hr-BA - Croatian (Latin, Bosnia and Herzegovina)",
            "hr-HR - Croatian",
            "hr-HR - Croatian (Croatia)",
            "hsb-DE - Upper Sorbian",
            "hsb-DE - Upper Sorbian (Germany)",
            "hu-HU - Hungarian",
            "hu-HU - Hungarian (Hungary)",
            "hy-AM - Armenian",
            "hy-AM - Armenian (Armenia)",
            "ibb-NG - Ibibio",
            "ibb-NG - Ibibio (Nigeria)",
            "id-ID - Indonesian",
            "id-ID - Indonesian (Indonesia)",
            "ig-NG - Igbo",
            "ig-NG - Igbo (Nigeria)",
            "ii-CN - Yi",
            "ii-CN - Yi (PRC)",
            "is-IS - Icelandic",
            "is-IS - Icelandic (Iceland)",
            "it-CH - Italian (Switzerland)",
            "it-IT - Italian",
            "it-IT - Italian (Italy)",
            "iu-Cans-CA - Inuktitut (Syllabics)",
            "iu-Cans-CA - Inuktitut (Syllabics, Canada)",
            "iu-Latn-CA - Inuktitut",
            "iu-Latn-CA - Inuktitut (Latin)",
            "iu-Latn-CA - Inuktitut (Latin, Canada)",
            "ja-JP - Japanese",
            "ja-JP - Japanese (Japan)",
            "ka-GE - Georgian",
            "ka-GE - Georgian (Georgia)",
            "kk-KZ - Kazakh",
            "kk-KZ - Kazakh (Kazakhstan)",
            "kl-GL - Greenlandic",
            "kl-GL - Greenlandic (Greenland)",
            "km-KH - Khmer",
            "km-KH - Khmer (Cambodia)",
            "kn-IN - Kannada",
            "kn-IN - Kannada (India)",
            "kok-IN - Konkani",
            "kok-IN - Konkani (India)",
            "ko-KR - Korean",
            "ko-KR - Korean (Korea)",
            "kr-Latn-NG - Kanuri",
            "kr-Latn-NG - Kanuri (Nigeria)",
            "ks-Arab-IN - Kashmiri",
            "ks-Arab-IN - Kashmiri (Perso-Arabic)",
            "ks-Deva-IN - Kashmiri (Devanagari, India)",
            "ku-Arab-IQ - Central Kurdish",
            "ku-Arab-IQ - Central Kurdish (Arabic)",
            "ku-Arab-IQ - Central Kurdish (Iraq)",
            "ky-KG - Kyrgyz",
            "ky-KG - Kyrgyz (Kyrgyzstan)",
            "la-001 - Latin",
            "la-001 - Latin (World)",
            "lb-LU - Luxembourgish",
            "lb-LU - Luxembourgish (Luxembourg)",
            "lo-LA - Lao",
            "lo-LA - Lao (Lao P.D.R.)",
            "lt-LT - Lithuanian",
            "lt-LT - Lithuanian (Lithuania)",
            "lv-LV - Latvian",
            "lv-LV - Latvian (Latvia)",
            "mi-NZ - Maori",
            "mi-NZ - Maori (New Zealand)",
            "mk-MK - Macedonian",
            "mk-MK - Macedonian (North Macedonia)",
            "ml-IN - Malayalam",
            "ml-IN - Malayalam (India)",
            "mni-IN - Manipuri",
            "mni-IN - Manipuri (India)",
            "mn-MN - Mongolian",
            "mn-MN - Mongolian (Cyrillic)",
            "mn-MN - Mongolian (Cyrillic, Mongolia)",
            "mn-Mong-CN - Mongolian (Traditional Mongolian)",
            "mn-Mong-CN - Mongolian (Traditional Mongolian, PRC)",
            "mn-Mong-MN - Mongolian (Traditional Mongolian, Mongolia)",
            "moh-CA - Mohawk",
            "moh-CA - Mohawk (Mohawk)",
            "mr-IN - Marathi",
            "mr-IN - Marathi (India)",
            "ms-BN - Malay (Brunei Darussalam)",
            "ms-MY - Malay",
            "ms-MY - Malay (Malaysia)",
            "mt-MT - Maltese",
            "mt-MT - Maltese (Malta)",
            "my-MM - Burmese",
            "my-MM - Burmese (Myanmar)",
            "nb-NO - Norwegian",
            "nb-NO - Norwegian (Bokmal)",
            "nb-NO - Norwegian, Bokmal (Norway)",
            "ne-IN - Nepali (India)",
            "ne-NP - Nepali",
            "ne-NP - Nepali (Nepal)",
            "nl-BE - Dutch (Belgium)",
            "nl-NL - Dutch",
            "nl-NL - Dutch (Netherlands)",
            "nn-NO - Norwegian (Nynorsk)",
            "nn-NO - Norwegian, Nynorsk (Norway)",
            "nso-ZA - Sesotho sa Leboa",
            "nso-ZA - Sesotho sa Leboa (South Africa)",
            "oc-FR - Occitan",
            "oc-FR - Occitan (France)",
            "om-ET - Oromo",
            "om-ET - Oromo (Ethiopia)",
            "or-IN - Odia",
            "or-IN - Odia (India)",
            "pa-Arab-PK - Punjabi (Arabic)",
            "pa-Arab-PK - Punjabi (Islamic Republic of Pakistan)",
            "pa-IN - Punjabi",
            "pa-IN - Punjabi (India)",
            "pap-029 - Papiamento",
            "pap-029 - Papiamento (Caribbean)",
            "pl-PL - Polish",
            "pl-PL - Polish (Poland)",
            "prs-AF - Dari",
            "prs-AF - Dari (Afghanistan)",
            "ps-AF - Pashto",
            "ps-AF - Pashto (Afghanistan)",
            "pt-BR - Portuguese",
            "pt-BR - Portuguese (Brazil)",
            "pt-PT - Portuguese (Portugal)",
            "quc-Latn-GT - K\'iche\'",
            "quc-Latn-GT - K\'iche\'",
            "quc-Latn-GT - K\'iche\' (Guatemala)",
            "quz-BO - Quechua",
            "quz-BO - Quechua (Bolivia)",
            "quz-EC - Quechua (Ecuador)",
            "quz-PE - Quechua (Peru)",
            "rm-CH - Romansh",
            "rm-CH - Romansh (Switzerland)",
            "ro-MD - Romanian (Moldova)",
            "ro-RO - Romanian",
            "ro-RO - Romanian (Romania)",
            "ru-MD - Russian (Moldova)",
            "ru-RU - Russian",
            "ru-RU - Russian (Russia)",
            "rw-RW - Kinyarwanda",
            "rw-RW - Kinyarwanda (Rwanda)",
            "sah-RU - Sakha",
            "sah-RU - Sakha (Russia)",
            "sa-IN - Sanskrit",
            "sa-IN - Sanskrit (India)",
            "sd-Arab-PK - Sindhi",
            "sd-Arab-PK - Sindhi (Arabic)",
            "sd-Arab-PK - Sindhi (Islamic Republic of Pakistan)",
            "sd-Deva-IN - Sindhi (Devanagari, India)",
            "se-FI - Sami, Northern (Finland)",
            "se-NO - Sami (Northern)",
            "se-NO - Sami, Northern (Norway)",
            "se-SE - Sami, Northern (Sweden)",
            "si-LK - Sinhala",
            "si-LK - Sinhala (Sri Lanka)",
            "sk-SK - Slovak",
            "sk-SK - Slovak (Slovakia)",
            "sl-SI - Slovenian",
            "sl-SI - Slovenian (Slovenia)",
            "sma-NO - Sami, Southern (Norway)",
            "sma-SE - Sami (Southern)",
            "sma-SE - Sami, Southern (Sweden)",
            "smj-NO - Sami, Lule (Norway)",
            "smj-SE - Sami (Lule)",
            "smj-SE - Sami, Lule (Sweden)",
            "smn-FI - Sami (Inari)",
            "smn-FI - Sami, Inari (Finland)",
            "sms-FI - Sami (Skolt)",
            "sms-FI - Sami, Skolt (Finland)",
            "so-SO - Somali",
            "so-SO - Somali (Somalia)",
            "sq-AL - Albanian",
            "sq-AL - Albanian (Albania)",
            "sr-Cyrl-BA - Serbian (Cyrillic, Bosnia and Herzegovina)",
            "sr-Cyrl-ME - Serbian (Cyrillic, Montenegro)",
            "sr-Cyrl-RS - Serbian (Cyrillic)",
            "sr-Cyrl-RS - Serbian (Cyrillic, Serbia)",
            "sr-Latn-BA - Serbian (Latin, Bosnia and Herzegovina)",
            "sr-Latn-ME - Serbian (Latin, Montenegro)",
            "sr-Latn-RS - Serbian",
            "sr-Latn-RS - Serbian (Latin)",
            "sr-Latn-RS - Serbian (Latin, Serbia)",
            "st-ZA - Southern Sotho",
            "st-ZA - Southern Sotho (South Africa)",
            "sv-FI - Swedish (Finland)",
            "sv-SE - Swedish",
            "sv-SE - Swedish (Sweden)",
            "sw-KE - Kiswahili",
            "sw-KE - Kiswahili (Kenya)",
            "syr-SY - Syriac",
            "syr-SY - Syriac (Syria)",
            "ta-IN - Tamil",
            "ta-IN - Tamil (India)",
            "ta-LK - Tamil (Sri Lanka)",
            "te-IN - Telugu",
            "te-IN - Telugu (India)",
            "tg-Cyrl-TJ - Tajik",
            "tg-Cyrl-TJ - Tajik (Cyrillic)",
            "tg-Cyrl-TJ - Tajik (Cyrillic, Tajikistan)",
            "th-TH - Thai",
            "th-TH - Thai (Thailand)",
            "ti-ER - Tigrinya",
            "ti-ER - Tigrinya (Eritrea)",
            "ti-ET - Tigrinya (Ethiopia)",
            "tk-TM - Turkmen",
            "tk-TM - Turkmen (Turkmenistan)",
            "tn-BW - Setswana (Botswana)",
            "tn-ZA - Setswana",
            "tn-ZA - Setswana (South Africa)",
            "tr-TR - Turkish",
            "tr-TR - Turkish (Turkey)",
            "ts-ZA - Tsonga",
            "ts-ZA - Tsonga (South Africa)",
            "tt-RU - Tatar",
            "tt-RU - Tatar (Russia)",
            "tzm-Arab-MA - Central Atlas Tamazight (Arabic, Morocco)",
            "tzm-Latn-DZ - Tamazight",
            "tzm-Latn-DZ - Tamazight (Latin)",
            "tzm-Latn-DZ - Tamazight (Latin, Algeria)",
            "tzm-Tfng-MA - Central Atlas Tamazight (Tifinagh, Morocco)",
            "tzm-Tfng-MA - Tamazight (Tifinagh)",
            "ug-CN - Uyghur",
            "ug-CN - Uyghur (PRC)",
            "uk-UA - Ukrainian",
            "uk-UA - Ukrainian (Ukraine)",
            "ur-IN - Urdu (India)",
            "ur-PK - Urdu",
            "ur-PK - Urdu (Islamic Republic of Pakistan)",
            "uz-Cyrl-UZ - Uzbek (Cyrillic)",
            "uz-Cyrl-UZ - Uzbek (Cyrillic, Uzbekistan)",
            "uz-Latn-UZ - Uzbek",
            "uz-Latn-UZ - Uzbek (Latin)",
            "uz-Latn-UZ - Uzbek (Latin, Uzbekistan)",
            "ve-ZA - Venda",
            "ve-ZA - Venda (South Africa)",
            "vi-VN - Vietnamese",
            "vi-VN - Vietnamese (Vietnam)",
            "wo-SN - Wolof",
            "wo-SN - Wolof (Senegal)",
            "xh-ZA - isiXhosa",
            "xh-ZA - isiXhosa (South Africa)",
            "yi-001 - Yiddish",
            "yi-001 - Yiddish (World)",
            "yo-NG - Yoruba",
            "yo-NG - Yoruba (Nigeria)",
            "zh-CN - Chinese",
            "zh-CN - Chinese (Simplified)",
            "zh-CN - Chinese (Simplified, PRC)",
            "zh-HK - Chinese (Traditional)",
            "zh-HK - Chinese (Traditional, Hong Kong S.A.R.)",
            "zh-MO - Chinese (Traditional, Macao S.A.R.)",
            "zh-SG - Chinese (Simplified, Singapore)",
            "zh-TW - Chinese (Traditional, Taiwan)",
            "zu-ZA - isiZulu",
            "zu-ZA - isiZulu (South Africa)"});
            this.comboBox1.Location = new System.Drawing.Point(21, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxSat
            // 
            this.checkBoxSat.AutoSize = true;
            this.checkBoxSat.Location = new System.Drawing.Point(21, 47);
            this.checkBoxSat.Name = "checkBoxSat";
            this.checkBoxSat.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSat.TabIndex = 3;
            this.checkBoxSat.UseVisualStyleBackColor = true;
            this.checkBoxSat.CheckedChanged += new System.EventHandler(this.checkBoxSat_CheckedChanged);
            // 
            // checkBoxDatum
            // 
            this.checkBoxDatum.AutoSize = true;
            this.checkBoxDatum.Location = new System.Drawing.Point(21, 119);
            this.checkBoxDatum.Name = "checkBoxDatum";
            this.checkBoxDatum.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDatum.TabIndex = 4;
            this.checkBoxDatum.UseVisualStyleBackColor = true;
            this.checkBoxDatum.CheckedChanged += new System.EventHandler(this.checkBoxDatum_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 240);
            this.Controls.Add(this.checkBoxDatum);
            this.Controls.Add(this.checkBoxSat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labela_datum);
            this.Controls.Add(this.labela_vrijeme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labela_vrijeme;
        private System.Windows.Forms.Label labela_datum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxSat;
        private System.Windows.Forms.CheckBox checkBoxDatum;
    }
}

