using Maple2.Trigger.Enum;

namespace Maple2.Trigger._61000003_me_003 {
    public static class _main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.OxQuiz);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612}, visible: false);
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
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
                context.WidgetAction(type: WidgetType.OxQuiz, name: "DevMode", args: "0");
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__0$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__1$", duration: 4000, boxId: 0);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State안내03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내03 : TriggerState {
            internal State안내03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__2$", duration: 4000, boxId: 0);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제1 : TriggerState {
            internal State문제1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGame(boxId: 105, round: 10, type: MiniGame.OXQuiz);
                context.StartMiniGameRound(boxId: 105, round: 1);
                context.SetAchievement(triggerId: 100, type: "trigger", code: "oxquiz_start");
                context.SetAchievement(triggerId: 100, type: "trigger", code: "dailyquest_start");
                context.GiveGuildExp(boxId: 0, type: 2);
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, script: "1,10");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PickQuiz", args: "1");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowQuiz", args: "15");
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State문제1벽Creation(context);
                }

                if (!context.UserDetected(boxIds: new []{105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제1벽Creation : TriggerState {
            internal State문제1벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Popup_Off_01");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제1정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제1정답체크 : TriggerState {
            internal State문제1정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PreJudge", args: "1");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Correct")) {
                    return new State문제1정답O(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Incorrect")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 101, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제2Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "1");
            }
        }

        private class State문제1정답X : TriggerState {
            internal State문제1정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 102, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제2Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "1");
            }
        }

        private class State문제2Prepare : TriggerState {
            internal State문제2Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__3$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제2(context);
                }

                if (!context.UserDetected(boxIds: new []{105})) {
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
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, script: "2,10");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PickQuiz", args: "1");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowQuiz", args: "15");
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State문제2벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제2벽Creation : TriggerState {
            internal State문제2벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Popup_Off_01");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제2정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제2정답체크 : TriggerState {
            internal State문제2정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PreJudge", args: "2");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Correct")) {
                    return new State문제2정답O(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Incorrect")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 101, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제3Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "2");
            }
        }

        private class State문제2정답X : TriggerState {
            internal State문제2정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 102, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제3Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "2");
            }
        }

        private class State문제3Prepare : TriggerState {
            internal State문제3Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__4$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제3(context);
                }

                if (!context.UserDetected(boxIds: new []{105})) {
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
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, script: "3,10");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PickQuiz", args: "2");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowQuiz", args: "15");
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State문제3벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제3벽Creation : TriggerState {
            internal State문제3벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Popup_Off_01");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제3정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제3정답체크 : TriggerState {
            internal State문제3정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PreJudge", args: "3");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Correct")) {
                    return new State문제3정답O(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Incorrect")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 101, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제4Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "3");
            }
        }

        private class State문제3정답X : TriggerState {
            internal State문제3정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 102, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제4Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "3");
            }
        }

        private class State문제4Prepare : TriggerState {
            internal State문제4Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__5$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제4(context);
                }

                if (!context.UserDetected(boxIds: new []{105})) {
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
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, script: "4,10");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PickQuiz", args: "2");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowQuiz", args: "15");
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State문제4벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제4벽Creation : TriggerState {
            internal State문제4벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Popup_Off_01");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제4정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제4정답체크 : TriggerState {
            internal State문제4정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PreJudge", args: "4");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Correct")) {
                    return new State문제4정답O(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Incorrect")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 101, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제5Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "4");
            }
        }

        private class State문제4정답X : TriggerState {
            internal State문제4정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 102, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제5Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "4");
            }
        }

        private class State문제5Prepare : TriggerState {
            internal State문제5Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__6$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제5(context);
                }

                if (!context.UserDetected(boxIds: new []{105})) {
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
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, script: "5,10");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PickQuiz", args: "3");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowQuiz", args: "15");
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State문제5벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제5벽Creation : TriggerState {
            internal State문제5벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Popup_Off_01");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제5정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제5정답체크 : TriggerState {
            internal State문제5정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PreJudge", args: "5");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Correct")) {
                    return new State문제5정답O(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Incorrect")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 101, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제6Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "5");
            }
        }

        private class State문제5정답X : TriggerState {
            internal State문제5정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 102, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제6Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "5");
            }
        }

        private class State문제6Prepare : TriggerState {
            internal State문제6Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__7$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제6(context);
                }

                if (!context.UserDetected(boxIds: new []{105})) {
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
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, script: "6,10");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PickQuiz", args: "3");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowQuiz", args: "15");
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State문제6벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제6벽Creation : TriggerState {
            internal State문제6벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Popup_Off_01");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제6정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제6정답체크 : TriggerState {
            internal State문제6정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PreJudge", args: "6");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Correct")) {
                    return new State문제6정답O(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Incorrect")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 101, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제7Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "6");
            }
        }

        private class State문제6정답X : TriggerState {
            internal State문제6정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 102, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제7Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "6");
            }
        }

        private class State문제7Prepare : TriggerState {
            internal State문제7Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__8$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제7(context);
                }

                if (!context.UserDetected(boxIds: new []{105})) {
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
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, script: "7,10");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PickQuiz", args: "4");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowQuiz", args: "15");
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State문제7벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제7벽Creation : TriggerState {
            internal State문제7벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Popup_Off_01");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제7정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제7정답체크 : TriggerState {
            internal State문제7정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PreJudge", args: "7");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Correct")) {
                    return new State문제7정답O(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Incorrect")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 101, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제8Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "7");
            }
        }

        private class State문제7정답X : TriggerState {
            internal State문제7정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 102, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제8Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "7");
            }
        }

        private class State문제8Prepare : TriggerState {
            internal State문제8Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__9$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제8(context);
                }

                if (!context.UserDetected(boxIds: new []{105})) {
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
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, script: "8,10");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PickQuiz", args: "4");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowQuiz", args: "15");
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State문제8벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제8벽Creation : TriggerState {
            internal State문제8벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Popup_Off_01");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제8정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제8정답체크 : TriggerState {
            internal State문제8정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PreJudge", args: "8");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Correct")) {
                    return new State문제8정답O(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Incorrect")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 101, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제9Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "8");
            }
        }

        private class State문제8정답X : TriggerState {
            internal State문제8정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 102, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제9Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "8");
            }
        }

        private class State문제9Prepare : TriggerState {
            internal State문제9Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__10$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제9(context);
                }

                if (!context.UserDetected(boxIds: new []{105})) {
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
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, script: "9,10");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PickQuiz", args: "5");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowQuiz", args: "15");
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State문제9벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제9벽Creation : TriggerState {
            internal State문제9벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Popup_Off_01");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제9정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제9정답체크 : TriggerState {
            internal State문제9정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PreJudge", args: "9");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Correct")) {
                    return new State문제9정답O(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Incorrect")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 101, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제10Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "9");
            }
        }

        private class State문제9정답X : TriggerState {
            internal State문제9정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 102, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제10Prepare(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "9");
            }
        }

        private class State문제10Prepare : TriggerState {
            internal State문제10Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{605}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__11$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제10(context);
                }

                if (!context.UserDetected(boxIds: new []{105})) {
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
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Start_01");
                context.SetEventUI(arg1: 0, script: "10,10");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PickQuiz", args: "5");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowQuiz", args: "15");
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State문제10벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제10벽Creation : TriggerState {
            internal State문제10벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Popup_Off_01");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문제10정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제10정답체크 : TriggerState {
            internal State문제10정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "PreJudge", args: "10");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Correct")) {
                    return new State문제10정답O(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuiz, condition: "Incorrect")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 101, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State완료체크(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "10");
            }
        }

        private class State문제10정답X : TriggerState {
            internal State문제10정답X(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.1f);
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Wrong_01");
                context.SetAchievement(triggerId: 102, type: "trigger", code: "oxquiz_correct");
                context.WidgetAction(type: WidgetType.OxQuiz, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State완료체크(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Judge", args: "10");
            }
        }

        private class State완료체크 : TriggerState {
            internal State완료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateSuccess(context);
                }

                if (!context.UserDetected(boxIds: new []{105})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 3, script: "$61000003_ME_003__MAIN__12$", duration: 5000, boxId: 105);
                context.SetEventUI(arg1: 4, script: "$61000003_ME_003__MAIN__13$", duration: 5000, notBoxId: 105);
                context.MiniGameCameraDirection(boxId: 105, cameraId: 301);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetLocalCamera(cameraId: 301, enabled: false);
                    return new State완료보상(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료보상 : TriggerState {
            internal State완료보상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuiz, name: "Winner");
                context.AddBuff(boxIds: new []{105}, skillId: 70000019, level: 1);
                context.MiniGameGiveReward(winnerBoxId: 105, contentType: "miniGame");
                context.EndMiniGame(winnerBoxId: 105, type: MiniGame.OXQuiz);
                context.SetAchievement(triggerId: 105, type: "trigger", code: "oxquiz_win");
            }

            public override TriggerState? Execute() {
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
                context.EndMiniGame(winnerBoxId: 105, type: MiniGame.OXQuiz);
                context.SetEffect(triggerIds: new []{608}, visible: true);
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetEventUI(arg1: 5, script: "$61000003_ME_003__MAIN__14$", duration: 3000, boxId: 0);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
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
                context.SetEffect(triggerIds: new []{609}, visible: true);
                context.SetEventUI(arg1: 1, script: "$61000003_ME_003__MAIN__15$", duration: 3000, boxId: 0);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    context.MoveUser(mapId: 0, portalId: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
