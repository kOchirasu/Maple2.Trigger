using System.Numerics;

namespace Maple2.Trigger._02020120_bf {
    public static class _daynightchangedebuff {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2222}, arg2: true);
                context.SetSkill(triggerIds: new []{1212}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 199) == 1) {
                    return new State낮밤변환신호Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낮밤변환신호Wait : TriggerState {
            internal State낮밤변환신호Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "DayNightChange") == 1) {
                    return new State낮시간으로변화Wait단계(context);
                }

                if (context.GetUserValue(key: "DayNightChange") == 2) {
                    return new State밤시간으로변화Wait단계(context);
                }

                if (context.GetUserValue(key: "DayNightChange") == 3) {
                    return new State디Buff모조리Remove(context);
                }

                if (context.GetUserValue(key: "DungeonReset") == 1) {
                    return new State낮시간으로변화하기_맵Reset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낮시간으로변화Wait단계 : TriggerState {
            internal State낮시간으로변화Wait단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1400)) {
                    return new State낮시간으로변화하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낮시간으로변화하기 : TriggerState {
            internal State낮시간으로변화하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeBackground(dds: "BG_RedLapenta_A.dds");
                context.SetAmbientLight(color: new Vector3(226f, 197f, 211f));
                context.SetDirectionalLight(diffuseColor: new Vector3(224f, 246f, 249f), specularColor: new Vector3(170f, 170f, 170f));
                context.SetSkill(triggerIds: new []{2222}, arg2: true);
                context.SetSkill(triggerIds: new []{1212}, arg2: false);
                context.SetUserValue(key: "DayNightChange", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State낮밤변환신호Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낮시간으로변화하기_맵Reset : TriggerState {
            internal State낮시간으로변화하기_맵Reset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{299}, skillId: 50004547, level: 2, arg4: false);
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "DayNightChange", value: 0);
                context.ChangeBackground(dds: "BG_RedLapenta_A.dds");
                context.SetAmbientLight(color: new Vector3(226f, 197f, 211f));
                context.SetDirectionalLight(diffuseColor: new Vector3(224f, 246f, 249f), specularColor: new Vector3(170f, 170f, 170f));
                context.SetSkill(triggerIds: new []{2222}, arg2: true);
                context.SetSkill(triggerIds: new []{1212}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State낮밤변환신호Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밤시간으로변화Wait단계 : TriggerState {
            internal State밤시간으로변화Wait단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1400)) {
                    return new State밤시간으로변화하기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밤시간으로변화하기 : TriggerState {
            internal State밤시간으로변화하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeBackground(dds: "BG_RedLapenta_B.dds");
                context.SetAmbientLight(color: new Vector3(120f, 119f, 183f));
                context.SetDirectionalLight(diffuseColor: new Vector3(193f, 100f, 119f), specularColor: new Vector3(170f, 170f, 170f));
                context.SetSkill(triggerIds: new []{2222}, arg2: false);
                context.SetSkill(triggerIds: new []{1212}, arg2: true);
                context.SetUserValue(key: "DayNightChange", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State낮밤변환신호Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디Buff모조리Remove : TriggerState {
            internal State디Buff모조리Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{299}, skillId: 50005315, level: 1, arg4: false);
                context.SetUserValue(key: "DayNightChange", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new State낮밤변환신호Wait(context);
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
