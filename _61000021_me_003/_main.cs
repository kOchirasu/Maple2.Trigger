using System;

namespace Maple2.Trigger._61000021_me_003 {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "100")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "OxQuizUGC");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetEffect(arg1: new int[] {606}, arg2: false);
                context.SetEffect(arg1: new int[] {607}, arg2: false);
                context.SetEffect(arg1: new int[] {608}, arg2: false);
                context.SetEffect(arg1: new int[] {609}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetEffect(arg1: new int[] {611}, arg2: false);
                context.SetEffect(arg1: new int[] {612}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116,
                        3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132,
                        3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148,
                        3149
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216,
                        3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232,
                        3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248,
                        3249
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316,
                        3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332,
                        3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348,
                        3349, 3350, 3351, 3352, 3353, 3354, 3355
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515,
                        3516, 3517, 3518, 3519, 3520, 3521
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 100, arg2: 50)) {
                    context.State = new State준비(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxID: 105);
                context.SetTimer(arg1: "2", arg2: 1);
                context.MoveUser(arg1: 61000021, arg2: 99, arg3: 104);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State시작(context);
                    return;
                }

                if (!context.UserDetected(arg1: "105")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxID: 105);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "IsQuizSubmit")) {
                    context.State = new State문제표시(context);
                    return;
                }

                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "IsFinished")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문제표시 : TriggerState {
            internal State문제표시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGame(boxId: 105, round: 10, gameName: "oxquiz_ugc");
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "PeekQuiz");
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "ShowQuiz", arg3: "15");
                context.SetMesh(
                    arg1: new int[] {
                        3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116,
                        3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132,
                        3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148,
                        3149
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216,
                        3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232,
                        3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248,
                        3249
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316,
                        3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332,
                        3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348,
                        3349, 3350, 3351, 3352, 3353, 3354, 3355
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515,
                        3516, 3517, 3518, 3519, 3520, 3521
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State벽생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽생성 : TriggerState {
            internal State벽생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(
                    arg1: new int[] {
                        3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515,
                        3516, 3517, 3518, 3519, 3520, 3521
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State정답체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정답체크 : TriggerState {
            internal State정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "PreJudge", arg3: "1");
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "Correct")) {
                    context.State = new State문제정답O(context);
                    return;
                }

                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "Incorrect")) {
                    context.State = new State문제정답X(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문제정답O : TriggerState {
            internal State문제정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new int[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(
                    arg1: new int[] {
                        3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216,
                        3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232,
                        3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248,
                        3249
                    }, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(
                    arg1: new int[] {
                        3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316,
                        3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332,
                        3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348,
                        3349, 3350, 3351, 3352, 3353, 3354, 3355
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517,
                        3518, 3519, 3520, 3521
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State문제정리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문제정답X : TriggerState {
            internal State문제정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new int[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(
                    arg1: new int[] {
                        3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116,
                        3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132,
                        3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148,
                        3149
                    }, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(
                    arg1: new int[] {
                        3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316,
                        3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332,
                        3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348,
                        3349, 3350, 3351, 3352, 3353, 3354, 3355
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517,
                        3518, 3519, 3520, 3521
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State문제정리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문제정리 : TriggerState {
            internal State문제정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116,
                        3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132,
                        3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148,
                        3149
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216,
                        3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232,
                        3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248,
                        3249
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316,
                        3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332,
                        3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348,
                        3349, 3350, 3351, 3352, 3353, 3354, 3355
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515,
                        3516, 3517, 3518, 3519, 3520, 3521
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "20", arg2: 10);
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "CleanUpQuiz");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGame(winnerBoxId: 105, gameName: "oxquiz_ugc");
                context.SetEffect(arg1: new int[] {608}, arg2: true);
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEventUI(arg1: 5, arg2: "$61000003_ME_003__MAIN__14$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State종료2 : TriggerState {
            internal State종료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.UnSetMiniGameAreaForHack();
                context.SetEffect(arg1: new int[] {609}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__15$", arg3: new int[] {3000}, arg4: "0");
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.MoveUser(arg1: 0, arg2: 0);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}