using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010038_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{6299}, visible: false);
                context.ShadowExpeditionCloseBossGauge();
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddBuff(boxIds: new []{199}, skillId: 70000109, level: 1, arg4: false, arg5: false);
                context.CreateMonster(spawnIds: new []{1805, 1806, 1201}, arg2: false);
                context.SpawnNpcRange(rangeId: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008}, isAutoTargeting: false);
                context.SpawnNpcRange(rangeId: new []{1101, 1102, 1103, 1104, 1105, 1106}, isAutoTargeting: false);
                context.SpawnNpcRange(rangeId: new []{1801, 1802, 1803, 1804}, isAutoTargeting: false);
                context.SetSkip(state: new StateStart(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetUserValue(triggerId: 999001, key: "GaugeOpen", value: 1);
                context.SetUserValue(triggerId: 992001, key: "WaveStart", value: 1);
                context.SetUserValue(triggerId: 999004, key: "AllertStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 150) {
                    return new State부상병발생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부상병발생 : TriggerState {
            internal State부상병발생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_nomal", duration: 7000, script: "$52010038_QD__main__4$", voice: @"ko/Npc/00002057");
                context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 300) {
                    return new State2차폭탄방어(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차폭탄방어 : TriggerState {
            internal State2차폭탄방어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 60, clearAtZero: true, display: true, arg5: 80);
                context.SetUserValue(triggerId: 992003, key: "bombStart", value: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new StateCinematic02종료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCamera304(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera304 : TriggerState {
            internal StateCamera304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 304, enable: true);
                context.SetSkip(state: new StateCinematic02종료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부관Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부관Script03 : TriggerState {
            internal State부관Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateCinematic02종료(context));
                context.AddCinematicTalk(npcId: 11003536, illustId: "Neirin_surprise", script: "$52010038_QD__MAIN__0$", duration: 7000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCinematic02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic02종료 : TriggerState {
            internal StateCinematic02종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSkip();
                context.SideNpcTalk(npcId: 11003537, illust: "Mason_closeEye", duration: 7000, script: "$52010038_QD__main__5$", voice: @"ko/Npc/00002095");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2008, 2009, 2010})) {
                    context.CreateMonster(spawnIds: new []{4020, 4020}, arg2: false);
                    context.ResetTimer(timerId: "99");
                    return new State2차폭탄방어완료조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차폭탄방어완료조건 : TriggerState {
            internal State2차폭탄방어완료조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2097})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 6000, script: "$52010038_QD__main__6$", voice: @"ko/Npc/00002106");
                    return new State3층이벤트스킵(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3층이벤트스킵 : TriggerState {
            internal State3층이벤트스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 700) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6201, 6202, 6203, 6204}, visible: false);
                context.CreateMonster(spawnIds: new []{2098}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new StateBossStopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
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
                context.SetSkip(state: new StateBossStopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBossScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossScript01 : TriggerState {
            internal StateBossScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateBossStopCinematic(context));
                context.AddCinematicTalk(npcId: 11003185, illustId: "ShadowClaw_normal", script: "$52010038_QD__MAIN__2$", duration: 5000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateBoss이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss이동 : TriggerState {
            internal StateBoss이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateBossStopCinematic(context));
                context.MoveNpc(spawnId: 2098, patrolName: "MS2PatrolData_2098");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateCamera303(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera303 : TriggerState {
            internal StateCamera303(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003185, illustId: "ShadowClaw_normal", script: "$52010038_QD__MAIN__3$", duration: 5000, align: Align.Left);
                context.CameraSelect(triggerId: 303, enable: true);
                context.SetSkip(state: new StateBossStopCinematic(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBossStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossStopCinematic : TriggerState {
            internal StateBossStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6299}, visible: true);
                context.SideNpcTalk(npcId: 11003533, illust: "Bliche_nomal", duration: 7000, script: "$52010038_QD__main__8$", voice: @"ko/Npc/00002058");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSkip();
                context.DestroyMonster(spawnIds: new []{2098});
                context.CreateMonster(spawnIds: new []{2099}, arg2: true);
                context.CreateMonster(spawnIds: new []{1099}, arg2: false);
                context.SetUserValue(triggerId: 992001, key: "WaveSlowDown", value: 1);
                context.SetUserValue(triggerId: 992002, key: "WaveStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 1000) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{1099})) {
                    context.SetUserValue(triggerId: 999001, key: "EngineIsDead", value: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
