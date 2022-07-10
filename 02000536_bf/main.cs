using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000536_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(spawnIds: new []{501, 502, 504, 505, 506, 507, 508, 509, 510, 511}, arg2: false);
                context.SetInteractObject(interactIds: new []{10003147}, state: 0);
                context.SetMesh(triggerIds: new []{9999}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701}, jobCode: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSceneSkip();
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateBattleStart(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{7000, 7003}, returnView: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: CaptionType.Vertical, title: "$02000536_BF__MAIN__0$", script: "$02000536_BF__MAIN__1$", align: Align.Center | Align.Right, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State하렌인사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌인사 : TriggerState {
            internal State하렌인사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{7003, 7001}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Bore_A", duration: 5000f);
                context.AddCinematicTalk(npcId: 23300001, script: "$02000536_BF__MAIN__2$", align: Align.Center, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State하렌인사2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하렌인사2 : TriggerState {
            internal State하렌인사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Attack_01_E,Attack_01_B");
                context.AddCinematicTalk(npcId: 23300001, script: "$02000536_BF__MAIN__3$", align: Align.Center, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 1, script: "$02000536_BF__MAIN__4$", duration: 3000);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.DestroyMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 101) <= 0.70f) {
                    return new State메이드군단을Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메이드군단을Spawn : TriggerState {
            internal State메이드군단을Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304}, arg2: false);
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_serious", duration: 4000, script: "$02000536_BF__MAIN__5$");
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 101) <= 0.50f) {
                    return new State메이드군단을Spawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메이드군단을Spawn2 : TriggerState {
            internal State메이드군단을Spawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{401, 402, 403, 404}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 101) <= 0.30f) {
                    return new StateMonsterDead체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDead체크 : TriggerState {
            internal StateMonsterDead체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_serious", duration: 4000, script: "$02000536_BF__MAIN__6$");
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new State던전Clear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전Clear : TriggerState {
            internal State던전Clear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_serious", duration: 3000, script: "$02000536_BF__MAIN__8$");
                context.SetMesh(triggerIds: new []{9999}, visible: false);
                context.DestroyMonster(spawnIds: new []{-1});
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTrigger완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger완료 : TriggerState {
            internal StateTrigger완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
