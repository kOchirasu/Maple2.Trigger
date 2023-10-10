using Maple2.Trigger.Enum;

namespace Maple2.Trigger._61000011_me {
    public static class _main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.OxQuizUGC);
            }

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
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612}, visible: false);
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "ShowHostUI");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuizUGC, condition: "IsStarted")) {
                    return new State게임시작(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuizUGC, condition: "IsCanceled")) {
                    return new State게임취소(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGame(boxId: 105, round: 10, type: MiniGame.OXQuizUgc, isShowResultUI: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxId: 105);
                context.SetTimer(timerId: "2", seconds: 1);
                context.MoveUser(mapId: 61000021, portalId: 99, boxId: 104);
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "StartRound");
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "HostUIChange", args: "InputQuiz");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxId: 105);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{105})) {
                    return new StateEnd(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuizUGC, condition: "IsCanceled")) {
                    return new State게임취소(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuizUGC, condition: "IsFinished")) {
                    return new State게임끝(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuizUGC, condition: "IsQuizSubmit")) {
                    return new State문제표시(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제표시 : TriggerState {
            internal State문제표시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "ShowQuiz", args: "15");
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "HostUIChange", args: "Move");
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "15", seconds: 15);
                context.SetAchievement(triggerId: 100, type: "trigger", code: "bjoxquiz_start");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State벽Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽Creation : TriggerState {
            internal State벽Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "CreateWall");
                context.PlaySystemSoundInBox(boxIds: new []{105}, sound: "System_Quiz_Popup_Off_01");
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State정답Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정답Wait : TriggerState {
            internal State정답Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "HostUIChange", args: "SelectAnswer");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuizUGC, condition: "IsRemoveWall")) {
                    return new State문제표시(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuizUGC, condition: "IsAnswerSubmit")) {
                    return new State정답체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정답체크 : TriggerState {
            internal State정답체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "PreJudge", args: "1");
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "HostUIChange", args: "Judge");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuizUGC, condition: "Correct")) {
                    return new State문제정답O(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuizUGC, condition: "Incorrect")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Wrong_01");
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
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
                context.PlaySystemSoundInBox(boxIds: new []{102}, sound: "System_Quiz_Answer_Correct_01");
                context.PlaySystemSoundInBox(boxIds: new []{101}, sound: "System_Quiz_Answer_Wrong_01");
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "ShowAnswer", args: "5");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149}, visible: false, meshCount: 49, arg4: 0, delay: 10);
                context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State문제정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문제정리 : TriggerState {
            internal State문제정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231, 3232, 3233, 3234, 3235, 3236, 3237, 3238, 3239, 3240, 3241, 3242, 3243, 3244, 3245, 3246, 3247, 3248, 3249, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344, 3345, 3346, 3347, 3348, 3349, 3350, 3351, 3352, 3353, 3354, 3355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3521}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "20", seconds: 2);
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "EndRound");
                context.MoveUser(mapId: 61000011, portalId: 99, boxId: 104);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.OxQuizUGC, condition: "IsFinished")) {
                    return new State게임끝(context);
                }

                if (context.WidgetCondition(type: WidgetType.OxQuizUGC, condition: "IsCanceled")) {
                    return new State게임취소(context);
                }

                if (context.TimeExpired(timerId: "20")) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임끝 : TriggerState {
            internal State게임끝(ITriggerContext context) : base(context) { }

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

        private class State게임취소 : TriggerState {
            internal State게임취소(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000011_ME__GAME_END_BY_CANCEL$", duration: 3000, boxId: 0);
                context.SetTimer(timerId: "2", seconds: 10);
                context.MoveUser(mapId: 61000003, portalId: 99, boxId: 104);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "EndGame");
                context.EndMiniGame(winnerBoxId: 105, type: MiniGame.OXQuizUgc, isOnlyWinner: true);
            }
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
                context.SetEventUI(arg1: 3, script: "$61000011_ME__WINNER_IS$", duration: 5000, boxId: 105);
                context.SetEventUI(arg1: 3, script: "$61000011_ME__ENVY_IS$", duration: 5000, notBoxId: 105);
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
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "EndGame");
                context.EndMiniGame(winnerBoxId: 105, type: MiniGame.OXQuizUgc, isOnlyWinner: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSuccess알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.OxQuizUGC, name: "EndGame");
                context.EndMiniGame(winnerBoxId: 105, type: MiniGame.OXQuizUgc, isOnlyWinner: true);
                context.SetEffect(triggerIds: new []{608}, visible: true);
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetEventUI(arg1: 5, script: "$61000011_ME__GAME_END_BY_ALL_RETIRED$", duration: 3000, boxId: 0);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess알림 : TriggerState {
            internal StateSuccess알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, script: "$61000011_ME__MAIN__SUCCESS_IS$", duration: 3000, boxId: 0);
                context.SetTimer(timerId: "40", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "40")) {
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
                context.SetEffect(triggerIds: new []{609}, visible: true);
                context.SetEventUI(arg1: 1, script: "$61000011_ME__MAIN__GOODBYE$", duration: 3000, boxId: 0);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    context.WidgetAction(type: WidgetType.OxQuizUGC, name: "MoveAllUser");
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
