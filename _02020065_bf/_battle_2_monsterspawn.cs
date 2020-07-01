namespace Maple2.Trigger._02020065_bf {
    public static class _battle_2_monsterspawn {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Battle_2_Clear", value: 0);
                context.StartCombineSpawn(groupId: new[] {505}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {506}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {507}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {508}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {509}, isStart: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.ResetTimer(arg1: "3");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_2_SpawnStart") == 1) {
                    return new State스폰_1_SE(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1_SE : TriggerState {
            internal State스폰_1_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ScoreBoardCreate(maxScore: 800);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {505}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_2_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State스폰_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1 : TriggerState {
            internal State스폰_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_2_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State스폰_2_SE(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_2_SE : TriggerState {
            internal State스폰_2_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_2_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_2 : TriggerState {
            internal State스폰_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 45, arg3: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {506}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1") || context.GetScoreBoardScore() >= 150) {
                    return new State스폰_3_SE(context);
                }

                if (context.GetUserValue(key: "Battle_2_SpawnStart") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_3_SE : TriggerState {
            internal State스폰_3_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_2_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_3 : TriggerState {
            internal State스폰_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 45, arg3: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {507}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2") || context.GetScoreBoardScore() >= 300) {
                    return new State스폰_4_SE(context);
                }

                if (context.GetUserValue(key: "Battle_2_SpawnStart") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_4_SE : TriggerState {
            internal State스폰_4_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_2_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_4 : TriggerState {
            internal State스폰_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 45, arg3: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {508}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3") || context.GetScoreBoardScore() >= 450) {
                    return new State스폰_5_SE(context);
                }

                if (context.GetUserValue(key: "Battle_2_SpawnStart") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_5_SE : TriggerState {
            internal State스폰_5_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_2_SpawnStart") == 0) {
                    return new State대기(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_5 : TriggerState {
            internal State스폰_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {509}, isStart: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.ScoreBoardRemove();
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_2_SpawnStart") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}