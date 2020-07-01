namespace Maple2.Trigger._61000011_me {
    public static class _main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "OxQuizUGC");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612}, arg2: false);
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "ShowHostUI");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "IsStarted")) {
                    return new State게임시작(context);
                }

                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "IsCanceled")) {
                    return new State게임취소(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGame(boxId: 105, round: 10, gameName: "oxquiz_ugc", isShowResultUI: "1");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxId: 105);
                context.SetTimer(arg1: "2", arg2: 1);
                context.MoveUser(arg1: 61000021, arg2: 99, arg3: 104);
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "StartRound");
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "HostUIChange", arg3: "InputQuiz");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxId: 105);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {105})) {
                    return new State종료(context);
                }

                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "IsCanceled")) {
                    return new State게임취소(context);
                }

                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "IsFinished")) {
                    return new State게임끝(context);
                }

                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "IsQuizSubmit")) {
                    return new State문제표시(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제표시 : TriggerState {
            internal State문제표시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "ShowQuiz", arg3: "15");
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "HostUIChange", arg3: "Move");
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "15", arg2: 15);
                context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "bjoxquiz_start");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State벽생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽생성 : TriggerState {
            internal State벽생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "CreateWall");
                context.PlaySystemSoundInBox(arg1: new[] {105}, arg2: "System_Quiz_Popup_Off_01");
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State정답대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정답대기 : TriggerState {
            internal State정답대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "HostUIChange", arg3: "SelectAnswer");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "IsRemoveWall")) {
                    return new State문제표시(context);
                }

                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "IsAnswerSubmit")) {
                    return new State정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정답체크 : TriggerState {
            internal State정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "PreJudge", arg3: "1");
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "HostUIChange", arg3: "Judge");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "Correct")) {
                    return new State문제정답O(context);
                }

                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "Incorrect")) {
                    return new State문제정답X(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제정답O : TriggerState {
            internal State문제정답O(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 101, expRate: 0f, meso: false);
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Wrong_01");
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제정답X : TriggerState {
            internal State문제정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0f, meso: false);
                context.PlaySystemSoundInBox(arg1: new[] {102}, arg2: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(arg1: new[] {101}, arg2: "System_Quiz_Answer_Wrong_01");
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "ShowAnswer", arg3: "5");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, arg2: false, arg3: 49, arg4: 0, arg5: 10);
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State문제정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제정리 : TriggerState {
            internal State문제정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "20", arg2: 2);
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "EndRound");
                context.MoveUser(arg1: 61000011, arg2: 99, arg3: 104);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "IsFinished")) {
                    return new State게임끝(context);
                }

                if (context.WidgetCondition(arg1: "OxQuizUGC", arg2: "IsCanceled")) {
                    return new State게임취소(context);
                }

                if (context.TimeExpired(arg1: "20")) {
                    return new State준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임끝 : TriggerState {
            internal State게임끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State성공(context);
                }

                if (!context.UserDetected(arg1: new[] {105})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임취소 : TriggerState {
            internal State게임취소(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$61000011_ME__GAME_END_BY_CANCEL$", arg3: 3000, arg4: "0");
                context.SetTimer(arg1: "2", arg2: 10);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "EndGame");
                context.EndMiniGame(winnerBoxId: 105, gameName: "oxquiz_ugc", isOnlyWinner: true);
            }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 61000003, arg2: 99, arg3: 104);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State우승자카메라연출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State우승자카메라연출 : TriggerState {
            internal State우승자카메라연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 3, arg2: "$61000011_ME__WINNER_IS$", arg3: 5000, arg4: "105");
                context.SetEventUI(arg1: 3, arg2: "$61000011_ME__ENVY_IS$", arg3: 5000, arg4: "!105");
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
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "EndGame");
                context.EndMiniGame(winnerBoxId: 105, gameName: "oxquiz_ugc", isOnlyWinner: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State성공알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "OxQuizUGC", arg2: "EndGame");
                context.EndMiniGame(winnerBoxId: 105, gameName: "oxquiz_ugc", isOnlyWinner: true);
                context.SetEffect(arg1: new[] {608}, arg2: true);
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEventUI(arg1: 5, arg2: "$61000011_ME__GAME_END_BY_ALL_RETIRED$", arg3: 3000, arg4: "0");
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State성공알림 : TriggerState {
            internal State성공알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, arg2: "$61000011_ME__MAIN__SUCCESS_IS$", arg3: 3000, arg4: "0");
                context.SetTimer(arg1: "40", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "40")) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.UnSetMiniGameAreaForHack();
                context.SetEffect(arg1: new[] {609}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$61000011_ME__MAIN__GOODBYE$", arg3: 3000, arg4: "0");
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.WidgetAction(arg1: "OxQuizUGC", arg2: "MoveAllUser");
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}