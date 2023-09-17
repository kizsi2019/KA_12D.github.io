﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace ML
{
    public partial class MLModel1
    {
        /// <summary>
        /// model input class for MLModel1.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"phone_name")]
            public string Phone_name { get; set; }

            [ColumnName(@"brand")]
            public string Brand { get; set; }

            [ColumnName(@"os")]
            public string Os { get; set; }

            [ColumnName(@"inches")]
            public float Inches { get; set; }

            [ColumnName(@"resolution")]
            public string Resolution { get; set; }

            [ColumnName(@"battery")]
            public float Battery { get; set; }

            [ColumnName(@"battery_type")]
            public string Battery_type { get; set; }

            [ColumnName(@"ram(GB)")]
            public float Ram_GB_ { get; set; }

            [ColumnName(@"announcement_date")]
            public string Announcement_date { get; set; }

            [ColumnName(@"weight(g)")]
            public float Weight_g_ { get; set; }

            [ColumnName(@"storage(GB)")]
            public float Storage_GB_ { get; set; }

            [ColumnName(@"video_720p")]
            public bool Video_720p { get; set; }

            [ColumnName(@"video_1080p")]
            public bool Video_1080p { get; set; }

            [ColumnName(@"video_4K")]
            public bool Video_4K { get; set; }

            [ColumnName(@"video_8K")]
            public string Video_8K { get; set; }

            [ColumnName(@"video_30fps")]
            public string Video_30fps { get; set; }

            [ColumnName(@"video_60fps")]
            public bool Video_60fps { get; set; }

            [ColumnName(@"video_120fps")]
            public bool Video_120fps { get; set; }

            [ColumnName(@"video_240fps")]
            public bool Video_240fps { get; set; }

            [ColumnName(@"video_480fps")]
            public string Video_480fps { get; set; }

            [ColumnName(@"video_960fps")]
            public bool Video_960fps { get; set; }

            [ColumnName(@"price(USD)")]
            public float Price_USD_ { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel1.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"phone_name")]
            public float[] Phone_name { get; set; }

            [ColumnName(@"brand")]
            public float[] Brand { get; set; }

            [ColumnName(@"os")]
            public float[] Os { get; set; }

            [ColumnName(@"inches")]
            public float Inches { get; set; }

            [ColumnName(@"resolution")]
            public float[] Resolution { get; set; }

            [ColumnName(@"battery")]
            public float Battery { get; set; }

            [ColumnName(@"battery_type")]
            public float[] Battery_type { get; set; }

            [ColumnName(@"ram(GB)")]
            public float Ram_GB_ { get; set; }

            [ColumnName(@"announcement_date")]
            public float[] Announcement_date { get; set; }

            [ColumnName(@"weight(g)")]
            public float Weight_g_ { get; set; }

            [ColumnName(@"storage(GB)")]
            public float Storage_GB_ { get; set; }

            [ColumnName(@"video_720p")]
            public float[] Video_720p { get; set; }

            [ColumnName(@"video_1080p")]
            public float[] Video_1080p { get; set; }

            [ColumnName(@"video_4K")]
            public bool Video_4K { get; set; }

            [ColumnName(@"video_8K")]
            public float[] Video_8K { get; set; }

            [ColumnName(@"video_30fps")]
            public float[] Video_30fps { get; set; }

            [ColumnName(@"video_60fps")]
            public float[] Video_60fps { get; set; }

            [ColumnName(@"video_120fps")]
            public float[] Video_120fps { get; set; }

            [ColumnName(@"video_240fps")]
            public float[] Video_240fps { get; set; }

            [ColumnName(@"video_480fps")]
            public float[] Video_480fps { get; set; }

            [ColumnName(@"video_960fps")]
            public float[] Video_960fps { get; set; }

            [ColumnName(@"price(USD)")]
            public float Price_USD_ { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public bool PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

            [ColumnName(@"Probability")]
            public float Probability { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLModel1.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
