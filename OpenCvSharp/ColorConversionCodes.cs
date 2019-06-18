﻿namespace Se7en.OpenCvSharp {

    /// <summary>
    /// Color conversion operation for cv::cvtColor
    /// </summary>
    public enum ColorConversionCodes {
        BGR2BGRA,
        RGB2RGBA = 0,
        BGRA2BGR,
        RGBA2RGB = 1,
        BGR2RGBA,
        RGB2BGRA = 2,
        RGBA2BGR,
        BGRA2RGB = 3,
        BGR2RGB,
        RGB2BGR = 4,
        BGRA2RGBA,
        RGBA2BGRA = 5,
        BGR2GRAY,
        RGB2GRAY,
        GRAY2BGR,
        GRAY2RGB = 8,
        GRAY2BGRA,
        GRAY2RGBA = 9,
        BGRA2GRAY,
        RGBA2GRAY,
        BGR2BGR565,
        RGB2BGR565,
        BGR5652BGR,
        BGR5652RGB,
        BGRA2BGR565,
        RGBA2BGR565,
        BGR5652BGRA,
        BGR5652RGBA,
        GRAY2BGR565,
        BGR5652GRAY,
        BGR2BGR555,
        RGB2BGR555,
        BGR5552BGR,
        BGR5552RGB,
        BGRA2BGR555,
        RGBA2BGR555,
        BGR5552BGRA,
        BGR5552RGBA,
        GRAY2BGR555,
        BGR5552GRAY,
        BGR2XYZ,
        RGB2XYZ,
        XYZ2BGR,
        XYZ2RGB,
        BGR2YCrCb,
        RGB2YCrCb,
        YCrCb2BGR,
        YCrCb2RGB,
        BGR2HSV,
        RGB2HSV,
        BGR2Lab = 44,
        RGB2Lab,
        BGR2Luv = 50,
        RGB2Luv,
        BGR2HLS,
        RGB2HLS,
        HSV2BGR,
        HSV2RGB,
        Lab2BGR,
        Lab2RGB,
        Luv2BGR,
        Luv2RGB,
        HLS2BGR,
        HLS2RGB,
        BGR2HSV_FULL = 66,
        RGB2HSV_FULL,
        BGR2HLS_FULL,
        RGB2HLS_FULL,
        HSV2BGR_FULL,
        HSV2RGB_FULL,
        HLS2BGR_FULL,
        HLS2RGB_FULL,
        LBGR2Lab,
        LRGB2Lab,
        LBGR2Luv,
        LRGB2Luv,
        Lab2LBGR,
        Lab2LRGB,
        Luv2LBGR,
        Luv2LRGB,
        BGR2YUV,
        RGB2YUV,
        YUV2BGR,
        YUV2RGB,
        YUV2RGB_NV12 = 90,
        YUV2BGR_NV12,
        YUV2RGB_NV21,
        YUV2BGR_NV21,
        YUV420sp2RGB = 92,
        YUV420sp2BGR,
        YUV2RGBA_NV12,
        YUV2BGRA_NV12,
        YUV2RGBA_NV21,
        YUV2BGRA_NV21,
        YUV420sp2RGBA = 96,
        YUV420sp2BGRA,
        YUV2RGB_YV12,
        YUV2BGR_YV12,
        YUV2RGB_IYUV,
        YUV2BGR_IYUV,
        YUV2RGB_I420 = 100,
        YUV2BGR_I420,
        YUV420p2RGB = 98,
        YUV420p2BGR,
        YUV2RGBA_YV12 = 102,
        YUV2BGRA_YV12,
        YUV2RGBA_IYUV,
        YUV2BGRA_IYUV,
        YUV2RGBA_I420 = 104,
        YUV2BGRA_I420,
        YUV420p2RGBA = 102,
        YUV420p2BGRA,
        YUV2GRAY_420 = 106,
        YUV2GRAY_NV21 = 106,
        YUV2GRAY_NV12 = 106,
        YUV2GRAY_YV12 = 106,
        YUV2GRAY_IYUV = 106,
        YUV2GRAY_I420 = 106,
        YUV420sp2GRAY = 106,
        YUV420p2GRAY = 106,
        YUV2RGB_UYVY,
        YUV2BGR_UYVY,
        YUV2RGB_Y422 = 107,
        YUV2BGR_Y422,
        YUV2RGB_UYNV = 107,
        YUV2BGR_UYNV,
        YUV2RGBA_UYVY = 111,
        YUV2BGRA_UYVY,
        YUV2RGBA_Y422 = 111,
        YUV2BGRA_Y422,
        YUV2RGBA_UYNV = 111,
        YUV2BGRA_UYNV,
        YUV2RGB_YUY2 = 115,
        YUV2BGR_YUY2,
        YUV2RGB_YVYU,
        YUV2BGR_YVYU,
        YUV2RGB_YUYV = 115,
        YUV2BGR_YUYV,
        YUV2RGB_YUNV = 115,
        YUV2BGR_YUNV,
        YUV2RGBA_YUY2 = 119,
        YUV2BGRA_YUY2,
        YUV2RGBA_YVYU,
        YUV2BGRA_YVYU,
        YUV2RGBA_YUYV = 119,
        YUV2BGRA_YUYV,
        YUV2RGBA_YUNV = 119,
        YUV2BGRA_YUNV,
        YUV2GRAY_UYVY = 123,
        YUV2GRAY_YUY2,
        YUV2GRAY_Y422 = 123,
        YUV2GRAY_UYNV = 123,
        YUV2GRAY_YVYU,
        YUV2GRAY_YUYV = 124,
        YUV2GRAY_YUNV = 124,
        RGBA2mRGBA,
        mRGBA2RGBA,
        RGB2YUV_I420,
        BGR2YUV_I420,
        RGB2YUV_IYUV = 127,
        BGR2YUV_IYUV,
        RGBA2YUV_I420,
        BGRA2YUV_I420,
        RGBA2YUV_IYUV = 129,
        BGRA2YUV_IYUV,
        RGB2YUV_YV12,
        BGR2YUV_YV12,
        RGBA2YUV_YV12,
        BGRA2YUV_YV12,
        BayerBG2BGR = 46,
        BayerGB2BGR,
        BayerRG2BGR,
        BayerGR2BGR,
        BayerBG2RGB = 48,
        BayerGB2RGB,
        BayerRG2RGB = 46,
        BayerGR2RGB,
        BayerBG2GRAY = 86,
        BayerGB2GRAY,
        BayerRG2GRAY,
        BayerGR2GRAY,
        BayerBG2BGR_VNG = 62,
        BayerGB2BGR_VNG,
        BayerRG2BGR_VNG,
        BayerGR2BGR_VNG,
        BayerBG2RGB_VNG = 64,
        BayerGB2RGB_VNG,
        BayerRG2RGB_VNG = 62,
        BayerGR2RGB_VNG,
        BayerBG2BGR_EA = 135,
        BayerGB2BGR_EA,
        BayerRG2BGR_EA,
        BayerGR2BGR_EA,
        BayerBG2RGB_EA = 137,
        BayerGB2RGB_EA,
        BayerRG2RGB_EA = 135,
        BayerGR2RGB_EA,
        COLORCVT_MAX = 139
    }
}