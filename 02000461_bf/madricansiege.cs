using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000461_bf {
    public static class _madricansiege {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99999102, key: "cannon02", value: 0);
                context.SetUserValue(triggerId: 99999103, key: "cannon03", value: 0);
                context.SetUserValue(triggerId: 99999104, key: "cannon04", value: 0);
                context.SetUserValue(triggerId: 99999105, key: "cannon05", value: 0);
                context.SetUserValue(triggerId: 99999102, key: "Bosscannon02", value: 0);
                context.SetUserValue(triggerId: 99999103, key: "Bosscannon03", value: 0);
                context.SetUserValue(triggerId: 99999104, key: "Bosscannon04", value: 0);
                context.SetUserValue(triggerId: 99999105, key: "Bosscannon05", value: 0);
                context.SetAgent(triggerIds: new []{8001, 8002, 8003, 8004, 8005, 8006, 8101, 8102, 8103, 8104, 8105, 8106, 8201, 8202, 8203, 8204, 8205, 8206}, visible: true);
                context.CameraSelect(triggerId: 300, enabled: true);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(spawnIds: new []{2000, 2001}, arg2: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3101, 3102, 3103, 3104, 3105, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3801, 3802, 3803, 3804}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 201, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 202, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 203, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 204, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 205, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 206, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 207, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 208, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 209, visible: false, initialSequence: "Dead_A");
                context.SetActor(triggerId: 210, visible: false, initialSequence: "Dead_A");
                context.RemoveBuff(boxId: 199, skillId: 99910150);
                context.SetInteractObject(interactIds: new []{12000045, 12000046, 12000054}, state: 2);
                context.RemoveBuff(boxId: 199, skillId: 99910140);
                context.SetInteractObject(interactIds: new []{12000047, 12000048, 12000049, 12000050, 12000055}, state: 2);
                context.RemoveBuff(boxId: 199, skillId: 99910130);
                context.SetInteractObject(interactIds: new []{12000051, 12000052, 12000056}, state: 2);
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.RemoveBuff(boxId: 199, skillId: 99910160);
                context.SetInteractObject(interactIds: new []{12000053, 12000057}, state: 2);
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
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDungeonInit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonInit : TriggerState {
            internal StateDungeonInit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1f);
                context.SetAgent(triggerIds: new []{8001, 8002, 8003, 8004, 8005, 8006}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2000, 2001})) {
                    context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.SetAgent(triggerIds: new []{8101, 8102, 8103, 8104, 8105, 8106}, visible: false);
                    return new State1차지원(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차지원 : TriggerState {
            internal State1차지원(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(spawnIds: new []{2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020}, isAutoTargeting: false);
                context.CreateMonster(spawnIds: new []{2002, 2003, 2004, 2005}, arg2: false);
                context.SetUserValue(triggerId: 99999101, key: "cannon01", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2901})) {
                    context.DestroyMonster(spawnIds: new []{2002});
                    context.SetAgent(triggerIds: new []{8201, 8202, 8203, 8204, 8205, 8206}, visible: false);
                    context.SetMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                    return new State다리건넘(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건넘 : TriggerState {
            internal State다리건넘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpeditionOpenBossGauge(maxGaugePoint: 1400);
                context.SetUserValue(triggerId: 99999102, key: "cannon02", value: 1);
                context.SetUserValue(triggerId: 99999103, key: "cannon03", value: 1);
                context.SetUserValue(triggerId: 99999104, key: "cannon04", value: 1);
                context.SetUserValue(triggerId: 99999105, key: "cannon05", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 450) {
                    return new State2차지원(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차지원 : TriggerState {
            internal State2차지원(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(spawnIds: new []{2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030}, isAutoTargeting: false);
            }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 700) {
                    return new State3차지원(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차지원 : TriggerState {
            internal State3차지원(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2031, 2032, 2033, 2034, 2035, 2036}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 1400) {
                    context.ShadowExpeditionCloseBossGauge();
                    return new StateBossSpawn_Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn_Delay : TriggerState {
            internal StateBossSpawn_Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036, 2901, 2902, 2903, 2904, 2905}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2099}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 2099) <= 0.50f) {
                    return new StateBoss_BuffPattern(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_BuffPattern : TriggerState {
            internal StateBoss_BuffPattern(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000461_BF__MADRICANSIEGE__0$", duration: 5000);
                context.SetUserValue(triggerId: 99999102, key: "Bosscannon02", value: 1);
                context.SetUserValue(triggerId: 99999103, key: "Bosscannon03", value: 1);
                context.SetUserValue(triggerId: 99999104, key: "Bosscannon04", value: 1);
                context.SetUserValue(triggerId: 99999105, key: "Bosscannon05", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2099})) {
                    return new State던전종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료 : TriggerState {
            internal State던전종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "Madracan01");
                context.SetAchievement(triggerId: 199, type: "trigger", code: "ClearMadracanSiege");
                context.DungeonClear();
                context.SetActor(triggerId: 201, visible: true, initialSequence: "Dead_A");
                context.SetActor(triggerId: 202, visible: true, initialSequence: "Dead_A");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "Dead_A");
                context.SetActor(triggerId: 204, visible: true, initialSequence: "Dead_A");
                context.SetActor(triggerId: 205, visible: true, initialSequence: "Dead_A");
                context.SetActor(triggerId: 206, visible: true, initialSequence: "Dead_A");
                context.SetActor(triggerId: 207, visible: true, initialSequence: "Dead_A");
                context.SetActor(triggerId: 208, visible: true, initialSequence: "Dead_A");
                context.SetActor(triggerId: 209, visible: true, initialSequence: "Dead_A");
                context.SetActor(triggerId: 210, visible: true, initialSequence: "Dead_A");
                context.SetUserValue(triggerId: 99999099, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerId: 99999098, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerId: 99999097, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerId: 99999096, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerId: 99999102, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerId: 99999103, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerId: 99999104, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerId: 99999105, key: "DungeonClear", value: 1);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
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
