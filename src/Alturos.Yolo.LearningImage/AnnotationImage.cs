﻿namespace Alturos.Yolo.LearningImage
{
    public class AnnotationImage
    {
        public bool Selected { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }

        public AnnotationImage()
        {
            Selected = true;
        }

        public AnnotationImage(AnnotationImage image)
        {
            Selected = true;
            FilePath = image.FilePath;
            FileName = image.FileName;
        }
    }
}
