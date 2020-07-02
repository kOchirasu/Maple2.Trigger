using System.Numerics;

namespace Maple2.Trigger._02020120_bf {
    public static class _daynightchangedebuff {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2222}, arg2: true);
                context.SetSkill(arg1: new[] {1212}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 199) == 1) {
                    return new State낮밤변환신호대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낮밤변환신호대기 : TriggerState {
            internal State낮밤변환신호대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DayNightChange") == 1) {
                    return new State낮시간으로변화대기단계(context);
                }

                if (context.GetUserValue(key: "DayNightChange") == 2) {
                    return new State밤시간으로변화대기단계(context);
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

        private class State낮시간으로변화대기단계 : TriggerState {
            internal State낮시간으로변화대기단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetAmbientLight(arg1: new Vector3(226f, 197f, 211f));
                context.SetDirectionalLight(arg1: new Vector3(224f, 246f, 249f), arg2: new Vector3(170f, 170f, 170f));
                context.SetSkill(arg1: new[] {2222}, arg2: true);
                context.SetSkill(arg1: new[] {1212}, arg2: false);
                context.SetUserValue(key: "DayNightChange", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State낮밤변환신호대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State낮시간으로변화하기_맵Reset : TriggerState {
            internal State낮시간으로변화하기_맵Reset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {299}, arg2: 50004547, arg3: 2, arg4: false);
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "DayNightChange", value: 0);
                context.ChangeBackground(dds: "BG_RedLapenta_A.dds");
                context.SetAmbientLight(arg1: new Vector3(226f, 197f, 211f));
                context.SetDirectionalLight(arg1: new Vector3(224f, 246f, 249f), arg2: new Vector3(170f, 170f, 170f));
                context.SetSkill(arg1: new[] {2222}, arg2: true);
                context.SetSkill(arg1: new[] {1212}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State낮밤변환신호대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밤시간으로변화대기단계 : TriggerState {
            internal State밤시간으로변화대기단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetAmbientLight(arg1: new Vector3(120f, 119f, 183f));
                context.SetDirectionalLight(arg1: new Vector3(193f, 100f, 119f), arg2: new Vector3(170f, 170f, 170f));
                context.SetSkill(arg1: new[] {2222}, arg2: false);
                context.SetSkill(arg1: new[] {1212}, arg2: true);
                context.SetUserValue(key: "DayNightChange", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State낮밤변환신호대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디Buff모조리Remove : TriggerState {
            internal State디Buff모조리Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {299}, arg2: 50005315, arg3: 1, arg4: false);
                context.SetUserValue(key: "DayNightChange", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new State낮밤변환신호대기(context);
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