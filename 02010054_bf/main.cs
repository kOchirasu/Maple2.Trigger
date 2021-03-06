using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010054_bf {
    public static class _main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetGravity(gravity: -9.8f);
                context.SetInteractObject(arg1: new[] {10000856, 10000857, 10000858, 10000859}, arg2: 2);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615, 3616, 3617, 3618, 3619, 3620, 3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520, 3330}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetEffect(arg1: new[] {6000, 6001, 6002, 6003, 6004}, arg2: false);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 607, 608, 609, 612, 613, 614, 615, 616}, arg2: true);
                context.SetEffect(arg1: new[] {620, 621, 622}, arg2: false);
                context.SetEffect(arg1: new[] {625, 626, 627, 628, 629}, arg2: true);
                context.CreateMonster(arg1: new[] {2099}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddBuff(arg1: new[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetSkip(state: new State인트로Cinematic스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematic해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic해제 : TriggerState {
            internal StateCinematic해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetCinematicUI(type: 0);
                    context.SetCinematicUI(type: 2);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로Cinematic스킵 : TriggerState {
            internal State인트로Cinematic스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.RemoveBuff(arg1: 199, arg2: 70000107);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.RemoveBuff(arg1: 199, arg2: 70000107);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20105407, textId: 20105407, duration: 3500);
                context.SetEffect(arg1: new[] {600, 601, 602, 603, 604, 6000}, arg2: false);
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {2001, 2002, 2003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State반응Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait01 : TriggerState {
            internal State반응Wait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105401, textId: 20105401);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(arg1: new[] {10000856}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000856}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20105401);
                    context.SetGravity(gravity: -39f);
                    return new State반응Wait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait02 : TriggerState {
            internal State반응Wait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000860, 10000861}, arg2: 0)) {
                    context.SetEventUI(arg1: 1, script: "$02010054_BF__MAIN__1$", arg3: 5000, arg4: "0");
                    context.SetInteractObject(arg1: new[] {10000858}, arg2: 1);
                    return new State반응Wait03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait03 : TriggerState {
            internal State반응Wait03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000858}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {607, 608, 609, 6001}, arg2: false);
                    context.SetEffect(arg1: new[] {6002}, arg2: true);
                    context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222}, arg2: true, arg3: 0, arg4: 50, arg5: 1f);
                    context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123}, arg2: true, arg3: 0, arg4: 50, arg5: 1f);
                    context.SetMesh(arg1: new[] {3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3608, 3609, 3610, 3611, 3612, 3613, 3614, 3615, 3616, 3617, 3618, 3619, 3620}, arg2: true, arg3: 0, arg4: 50, arg5: 1f);
                    context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513, 3514, 3515, 3516, 3517, 3518, 3519, 3520}, arg2: true, arg3: 0, arg4: 50, arg5: 1f);
                    context.CreateMonster(arg1: new[] {2011, 2014, 2015, 2020, 2021}, arg2: false);
                    context.SetGravity(gravity: -9.8f);
                    return new State인원체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인원체크 : TriggerState {
            internal State인원체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonMaxUserCount() == 1) {
                    return new State반응둘중하나만(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new State반응둘다01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응둘다01 : TriggerState {
            internal State반응둘다01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000884, 10000885}, arg2: 0)) {
                    return new State반응Wait05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응둘중하나만 : TriggerState {
            internal State반응둘중하나만(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000884}, arg2: 0)) {
                    return new State반응Wait05(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000885}, arg2: 0)) {
                    return new State반응Wait05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait05 : TriggerState {
            internal State반응Wait05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000857, 10000859}, arg2: 1);
                context.ShowGuideSummary(entityId: 20105401, textId: 20105401);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000857}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20105401);
                    context.SetGravity(gravity: -39f);
                    return new StateStarCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStarCreation : TriggerState {
            internal StateStarCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3315, 3316, 3317, 3318, 3319, 3320, 3321}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {3315, 3316, 3317, 3318, 3319, 3320, 3321}, arg2: false, arg3: 0, arg4: 900, arg5: 2f);
                    return new State반응Wait06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait06 : TriggerState {
            internal State반응Wait06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000859}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {3330}, arg2: true, arg3: 0, arg4: 0, arg5: 3f);
                    context.SetPortal(portalId: 10, visible: false, enabled: true, minimapVisible: false);
                    context.SetGravity(gravity: -9.8f);
                    return new State중간Boss소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중간Boss소환 : TriggerState {
            internal State중간Boss소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2098}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2098})) {
                    context.SetEffect(arg1: new[] {6003}, arg2: false);
                    return new State골렘소환Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State골렘소환Wait : TriggerState {
            internal State골렘소환Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {612, 613, 614, 615, 616}, arg2: false);
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {107})) {
                    return new State골렘소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State골렘소환 : TriggerState {
            internal State골렘소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {620}, arg2: true);
                context.CreateMonster(arg1: new[] {2024}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State골렘소환2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State골렘소환2 : TriggerState {
            internal State골렘소환2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {621}, arg2: true);
                context.CreateMonster(arg1: new[] {2025}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State골렘소환3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State골렘소환3 : TriggerState {
            internal State골렘소환3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {622}, arg2: true);
                context.CreateMonster(arg1: new[] {2026}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2024, 2025, 2026})) {
                    return new State그라즈나전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그라즈나전투 : TriggerState {
            internal State그라즈나전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {625, 626, 627, 628, 629, 6004}, arg2: false);
                context.SetMesh(arg1: new[] {3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2099})) {
                    return new StateEndDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndDelay : TriggerState {
            internal StateEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3130, 3131, 3132, 3133, 3134, 3135, 3136}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetTimer(id: "4", arg2: 4);
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}