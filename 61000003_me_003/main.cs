namespace Maple2.Trigger._61000003_me_003 {
    public static class _main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "OxQuiz");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612}, arg2: false);
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 100) == 50) {
                    return new StateStartPrepare(context);
                }

                if (context.WaitTick(waitTick: 60000)) {
                    return new StateStartPrepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartPrepare : TriggerState {
            internal StateStartPrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxId: 105);
                context.WidgetAction(arg1: "OxQuiz", arg2: "DevMode", arg3: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내01 : TriggerState {
            internal State안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__0$", arg3: 5000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State안내02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내02 : TriggerState {
            internal State안내02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__1$", arg3: 4000, arg4: "0");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State안내03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내03 : TriggerState {
            internal State안내03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__2$", arg3: 4000, arg4: "0");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제1 : TriggerState {
            internal State문제1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGame(boxId: 105, round: 10, gameName: "oxquiz");
                context.StartMiniGameRound(boxId: 105, round: 1);
                context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "oxquiz_start");
                context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "dailyquest_start");
                context.GiveGuildExp(boxId: false, type: 2);
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, arg2: "1,10");
                context.WidgetAction(arg1: "OxQuiz", arg2: "PickQuiz", arg3: "1");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowQuiz", arg3: "15");
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State문제1벽Creation(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제1벽Creation : TriggerState {
            internal State문제1벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제1정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제1정답체크 : TriggerState {
            internal State문제1정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "PreJudge", arg3: "1");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Correct")) {
                    return new State문제1정답O(context);
                }

                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Incorrect")) {
                    return new State문제1정답X(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제1정답O : TriggerState {
            internal State문제1정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제2Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "1");
            }
        }

        private class State문제1정답X : TriggerState {
            internal State문제1정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제2Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "1");
            }
        }

        private class State문제2Prepare : TriggerState {
            internal State문제2Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__3$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제2(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제2 : TriggerState {
            internal State문제2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 105, round: 2);
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, arg2: "2,10");
                context.WidgetAction(arg1: "OxQuiz", arg2: "PickQuiz", arg3: "1");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowQuiz", arg3: "15");
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State문제2벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제2벽Creation : TriggerState {
            internal State문제2벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제2정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제2정답체크 : TriggerState {
            internal State문제2정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "PreJudge", arg3: "2");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Correct")) {
                    return new State문제2정답O(context);
                }

                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Incorrect")) {
                    return new State문제2정답X(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제2정답O : TriggerState {
            internal State문제2정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제3Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "2");
            }
        }

        private class State문제2정답X : TriggerState {
            internal State문제2정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제3Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "2");
            }
        }

        private class State문제3Prepare : TriggerState {
            internal State문제3Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__4$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제3(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제3 : TriggerState {
            internal State문제3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 105, round: 3);
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, arg2: "3,10");
                context.WidgetAction(arg1: "OxQuiz", arg2: "PickQuiz", arg3: "2");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowQuiz", arg3: "15");
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State문제3벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제3벽Creation : TriggerState {
            internal State문제3벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제3정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제3정답체크 : TriggerState {
            internal State문제3정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "PreJudge", arg3: "3");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Correct")) {
                    return new State문제3정답O(context);
                }

                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Incorrect")) {
                    return new State문제3정답X(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제3정답O : TriggerState {
            internal State문제3정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제4Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "3");
            }
        }

        private class State문제3정답X : TriggerState {
            internal State문제3정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제4Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "3");
            }
        }

        private class State문제4Prepare : TriggerState {
            internal State문제4Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__5$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제4(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제4 : TriggerState {
            internal State문제4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 105, round: 4);
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, arg2: "4,10");
                context.WidgetAction(arg1: "OxQuiz", arg2: "PickQuiz", arg3: "2");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowQuiz", arg3: "15");
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State문제4벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제4벽Creation : TriggerState {
            internal State문제4벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제4정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제4정답체크 : TriggerState {
            internal State문제4정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "PreJudge", arg3: "4");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Correct")) {
                    return new State문제4정답O(context);
                }

                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Incorrect")) {
                    return new State문제4정답X(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제4정답O : TriggerState {
            internal State문제4정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제5Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "4");
            }
        }

        private class State문제4정답X : TriggerState {
            internal State문제4정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제5Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "4");
            }
        }

        private class State문제5Prepare : TriggerState {
            internal State문제5Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__6$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제5(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제5 : TriggerState {
            internal State문제5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 105, round: 5);
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, arg2: "5,10");
                context.WidgetAction(arg1: "OxQuiz", arg2: "PickQuiz", arg3: "3");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowQuiz", arg3: "15");
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State문제5벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제5벽Creation : TriggerState {
            internal State문제5벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제5정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제5정답체크 : TriggerState {
            internal State문제5정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "PreJudge", arg3: "5");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Correct")) {
                    return new State문제5정답O(context);
                }

                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Incorrect")) {
                    return new State문제5정답X(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제5정답O : TriggerState {
            internal State문제5정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제6Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "5");
            }
        }

        private class State문제5정답X : TriggerState {
            internal State문제5정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제6Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "5");
            }
        }

        private class State문제6Prepare : TriggerState {
            internal State문제6Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__7$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제6(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제6 : TriggerState {
            internal State문제6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 105, round: 6);
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, arg2: "6,10");
                context.WidgetAction(arg1: "OxQuiz", arg2: "PickQuiz", arg3: "3");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowQuiz", arg3: "15");
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State문제6벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제6벽Creation : TriggerState {
            internal State문제6벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제6정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제6정답체크 : TriggerState {
            internal State문제6정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "PreJudge", arg3: "6");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Correct")) {
                    return new State문제6정답O(context);
                }

                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Incorrect")) {
                    return new State문제6정답X(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제6정답O : TriggerState {
            internal State문제6정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제7Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "6");
            }
        }

        private class State문제6정답X : TriggerState {
            internal State문제6정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제7Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "6");
            }
        }

        private class State문제7Prepare : TriggerState {
            internal State문제7Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__8$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제7(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제7 : TriggerState {
            internal State문제7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 105, round: 7);
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, arg2: "7,10");
                context.WidgetAction(arg1: "OxQuiz", arg2: "PickQuiz", arg3: "4");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowQuiz", arg3: "15");
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State문제7벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제7벽Creation : TriggerState {
            internal State문제7벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제7정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제7정답체크 : TriggerState {
            internal State문제7정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "PreJudge", arg3: "7");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Correct")) {
                    return new State문제7정답O(context);
                }

                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Incorrect")) {
                    return new State문제7정답X(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제7정답O : TriggerState {
            internal State문제7정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제8Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "7");
            }
        }

        private class State문제7정답X : TriggerState {
            internal State문제7정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제8Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "7");
            }
        }

        private class State문제8Prepare : TriggerState {
            internal State문제8Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__9$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제8(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제8 : TriggerState {
            internal State문제8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 105, round: 8);
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, arg2: "8,10");
                context.WidgetAction(arg1: "OxQuiz", arg2: "PickQuiz", arg3: "4");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowQuiz", arg3: "15");
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State문제8벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제8벽Creation : TriggerState {
            internal State문제8벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제8정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제8정답체크 : TriggerState {
            internal State문제8정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "PreJudge", arg3: "8");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Correct")) {
                    return new State문제8정답O(context);
                }

                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Incorrect")) {
                    return new State문제8정답X(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제8정답O : TriggerState {
            internal State문제8정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제9Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "8");
            }
        }

        private class State문제8정답X : TriggerState {
            internal State문제8정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제9Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "8");
            }
        }

        private class State문제9Prepare : TriggerState {
            internal State문제9Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__10$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제9(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제9 : TriggerState {
            internal State문제9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 105, round: 9);
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, arg2: "9,10");
                context.WidgetAction(arg1: "OxQuiz", arg2: "PickQuiz", arg3: "5");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowQuiz", arg3: "15");
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State문제9벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제9벽Creation : TriggerState {
            internal State문제9벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제9정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제9정답체크 : TriggerState {
            internal State문제9정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "PreJudge", arg3: "9");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Correct")) {
                    return new State문제9정답O(context);
                }

                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Incorrect")) {
                    return new State문제9정답X(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제9정답O : TriggerState {
            internal State문제9정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제10Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "9");
            }
        }

        private class State문제9정답X : TriggerState {
            internal State문제9정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제10Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "9");
            }
        }

        private class State문제10Prepare : TriggerState {
            internal State문제10Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__11$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제10(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제10 : TriggerState {
            internal State문제10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 105, round: 10);
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, arg2: "10,10");
                context.WidgetAction(arg1: "OxQuiz", arg2: "PickQuiz", arg3: "5");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowQuiz", arg3: "15");
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State문제10벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제10벽Creation : TriggerState {
            internal State문제10벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State문제10정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제10정답체크 : TriggerState {
            internal State문제10정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "PreJudge", arg3: "10");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Correct")) {
                    return new State문제10정답O(context);
                }

                if (context.WidgetCondition(arg1: "OxQuiz", arg2: "Incorrect")) {
                    return new State문제10정답X(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제10정답O : TriggerState {
            internal State문제10정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 101, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State완료체크(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "10");
            }
        }

        private class State문제10정답X : TriggerState {
            internal State문제10정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "oxquiz_correct");
                context.WidgetAction(arg1: "OxQuiz", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State완료체크(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Judge", arg3: "10");
            }
        }

        private class State완료체크 : TriggerState {
            internal State완료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateSuccess(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State우승자CameraCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State우승자CameraCinematic : TriggerState {
            internal State우승자CameraCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 3, arg2: "$61000003_ME_003__MAIN__12$", arg3: 5000, arg4: "105");
                context.SetEventUI(arg1: 4, arg2: "$61000003_ME_003__MAIN__13$", arg3: 5000, arg4: "!105");
                context.MiniGameCameraDirection(boxId: 105, cameraId: 301);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetLocalCamera(cameraId: 301, enable: false);
                    return new State완료보상(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료보상 : TriggerState {
            internal State완료보상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuiz", arg2: "Winner");
                context.AddBuff(arg1: new[] {105}, arg2: 70000019, arg3: 1);
                context.MiniGameGiveReward(winnerBoxId: 105, contentType: "miniGame");
                context.EndMiniGame(winnerBoxId: 105, gameName: "oxquiz");
                context.SetAchievement(arg1: 105, arg2: "trigger", arg3: "oxquiz_win");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnd2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 105);
                context.EndMiniGame(winnerBoxId: 105, gameName: "oxquiz");
                context.SetEffect(arg1: new[] {608}, arg2: true);
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEventUI(arg1: 5, arg2: "$61000003_ME_003__MAIN__14$", arg3: 3000, arg4: "0");
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEnd2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd2 : TriggerState {
            internal StateEnd2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.UnSetMiniGameAreaForHack();
                context.SetEffect(arg1: new[] {609}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$61000003_ME_003__MAIN__15$", arg3: 3000, arg4: "0");
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.MoveUser(arg1: 0, arg2: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}