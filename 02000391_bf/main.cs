using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000391_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10001108}, state: 2);
                context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064, 3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3093, 3094, 3095, 3096, 3097, 3098, 3099, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3190, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3198, 3199, 3200, 3201, 3901, 3902, 3903, 3904}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{1099, 2094, 2095, 2096, 2097, 2098, 2099}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{601, 602, 603}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateStopCinematic(context));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 300, enable: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State부선장Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부선장Script01 : TriggerState {
            internal State부선장Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 24003011, script: "$02000391_BF__MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State해적이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해적이동01 : TriggerState {
            internal State해적이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 2099, script: "$02000391_BF__MAIN__1$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 1099, sequenceName: "Attack_01_C");
                context.CameraSelect(triggerId: 301, enable: true);
                context.MoveNpc(spawnId: 2094, patrolName: "MS2PatrolData_2094A");
                context.MoveNpc(spawnId: 2095, patrolName: "MS2PatrolData_2095A");
                context.MoveNpc(spawnId: 2096, patrolName: "MS2PatrolData_2096A");
                context.MoveNpc(spawnId: 2097, patrolName: "MS2PatrolData_2097A");
                context.MoveNpc(spawnId: 2098, patrolName: "MS2PatrolData_2098A");
                context.MoveNpc(spawnId: 2099, patrolName: "MS2PatrolData_2099A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera302(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera302 : TriggerState {
            internal StateCamera302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부선장Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부선장Script03 : TriggerState {
            internal State부선장Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 303, enable: true);
                context.SetConversation(type: 2, spawnId: 24003011, script: "$02000391_BF__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세이렌Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세이렌Script01 : TriggerState {
            internal State세이렌Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 309, enable: true);
                context.SetConversation(type: 2, spawnId: 24003010, script: "$02000391_BF__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera310(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera310 : TriggerState {
            internal StateCamera310(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "Dungeon_Siren_Harp01");
                context.SetNpcEmotionSequence(spawnId: 1098, sequenceName: "Attack_01_D");
                context.SetConversation(type: 1, spawnId: 1099, script: "$02000391_BF__MAIN__4$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 1099, sequenceName: "Attack_01_D");
                context.CameraSelect(triggerId: 310, enable: true);
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.AddBuff(boxIds: new []{2094}, skillId: 70000055, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{2095}, skillId: 70000055, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{2096}, skillId: 70000055, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{2097}, skillId: 70000055, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{2098}, skillId: 70000055, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{2099}, skillId: 70000055, level: 1, arg4: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera304(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera304 : TriggerState {
            internal StateCamera304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 2099, script: "$02000391_BF__MAIN__5$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 1099, sequenceName: "Attack_01_I");
                context.CameraSelect(triggerId: 304, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1300)) {
                    context.DestroyMonster(spawnIds: new []{1099});
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera305(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera305 : TriggerState {
            internal StateCamera305(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: false);
                context.DestroyMonster(spawnIds: new []{2094, 2095, 2096, 2097, 2098, 2099});
                context.CreateMonster(spawnIds: new []{2100, 1098}, arg2: false);
                context.CameraSelect(triggerId: 305, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State세이렌연주02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세이렌연주02 : TriggerState {
            internal State세이렌연주02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1098, script: "$02000391_BF__MAIN__6$", arg4: 3, arg5: 0);
                context.PlaySystemSoundInBox(sound: "Dungeon_Siren_Harp01");
                context.SetNpcEmotionSequence(spawnId: 1098, sequenceName: "Attack_01_D");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State물큐브Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State물큐브Remove : TriggerState {
            internal State물큐브Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064, 3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3093, 3094, 3095, 3096, 3097, 3098, 3099, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3190, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3198, 3199, 3200, 3201}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State세이렌이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세이렌이동 : TriggerState {
            internal State세이렌이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 1098, script: "$02000391_BF__MAIN__7$", arg4: 3, arg5: 0);
                context.CameraSelect(triggerId: 306, enable: true);
                context.MoveNpc(spawnId: 1098, patrolName: "MS2PatrolData_1098A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateCamera307(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera307 : TriggerState {
            internal StateCamera307(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1098});
                context.CameraSelect(triggerId: 307, enable: true);
                context.SetConversation(type: 2, spawnId: 24003011, script: "$02000391_BF__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera308(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera308 : TriggerState {
            internal StateCamera308(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011}, isAutoTargeting: false);
                context.CameraSelect(triggerId: 308, enable: true);
                context.SetNpcEmotionSequence(spawnId: 2100, sequenceName: "Attack_01_A");
                context.SetConversation(type: 1, spawnId: 2100, script: "$02000391_BF__MAIN__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetEffect(triggerIds: new []{603}, visible: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064, 3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3093, 3094, 3095, 3096, 3097, 3098, 3099, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3190, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3198, 3199, 3200, 3201}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3901, 3902, 3903, 3904}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DestroyMonster(spawnIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 1098, 1099, 2094, 2095, 2096, 2097, 2098, 2099, 2100});
                    return new StateRoomCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateDungeonInit(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuestDungeonStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonInit : TriggerState {
            internal StateDungeonInit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2199}, arg2: false);
                context.SpawnNpcRange(rangeId: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011}, isAutoTargeting: false);
                context.SpawnNpcRange(rangeId: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016}, isAutoTargeting: false);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039101, textId: 20039101, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2199})) {
                    return new StateDeadDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestDungeonStart : TriggerState {
            internal StateQuestDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2299}, arg2: false);
                context.SpawnNpcRange(rangeId: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011}, isAutoTargeting: false);
                context.SpawnNpcRange(rangeId: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016}, isAutoTargeting: false);
                context.ShowGuideSummary(entityId: 20039101, textId: 20039101, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2299})) {
                    return new StateDeadDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeadDelay : TriggerState {
            internal StateDeadDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.DestroyMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011});
                    return new State오브젝트Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트Camera : TriggerState {
            internal State오브젝트Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new State하프반응Wait(context));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.CameraSelect(triggerId: 307, enable: true);
                context.SetInteractObject(interactIds: new []{10001108}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State하프반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하프반응Wait : TriggerState {
            internal State하프반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip();
                context.CameraReset(interpolationTime: 0.0f);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039102, textId: 20039102, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001108}, arg2: 0)) {
                    context.PlaySystemSoundInBox(sound: "Dungeon_Siren_Harp01");
                    context.SetEffect(triggerIds: new []{601}, visible: false);
                    return new State연주Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연주Delay : TriggerState {
            internal State연주Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State물큐브Remove2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State물큐브Remove2 : TriggerState {
            internal State물큐브Remove2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateEnd(context));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.CameraSelect(triggerId: 305, enable: true);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056, 3057, 3058, 3059, 3060, 3061, 3062, 3063, 3064, 3065, 3066, 3067, 3068, 3069, 3070, 3071, 3072, 3073, 3074, 3075, 3076, 3077, 3078, 3079, 3080, 3081, 3082, 3083, 3084, 3085, 3086, 3087, 3088, 3089, 3090, 3091, 3092, 3093, 3094, 3095, 3096, 3097, 3098, 3099, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147, 3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158, 3159, 3160, 3161, 3162, 3163, 3164, 3165, 3166, 3167, 3168, 3169, 3170, 3171, 3172, 3173, 3174, 3175, 3176, 3177, 3178, 3179, 3180, 3181, 3182, 3183, 3184, 3185, 3186, 3187, 3188, 3189, 3190, 3191, 3192, 3193, 3194, 3195, 3196, 3197, 3198, 3199, 3200, 3201}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 2, visible: false, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039103, textId: 20039103);
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
